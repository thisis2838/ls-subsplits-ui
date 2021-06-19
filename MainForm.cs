using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static ls_subsplits_ui.FileHandler;

namespace ls_subsplits_ui
{
    public partial class MainForm : Form
    {
        private FileHandler _fileHanlder = new FileHandler();
        private OrderedDictionary _splits = new OrderedDictionary();
        private int GetCurSplitID => (int)gridSplits.SelectedRows[0].Cells[1].Value;
        private Split GetCurSplit()
        {
            foreach (Split split in _splits.Values)
                if (split.ID == GetCurSplitID)
                    return split;
            return null;
        }
        public static int SplitIDCount = 0;
        private XmlNode _autoSplitterSettings;
        public MainForm()
        {
            InitializeComponent();
            gridSplits.RowsAdded += RowsAdded;
            gridSplits.SelectionChanged += gridSplits_RowStateChanged;
            gridSubsplits.RowsAdded += RowsAdded;
            gridSplits.CellValueChanged += gridSplits_CellValueChanged;
        }

        public class Split
        {
            public Split(int id, string name = "")
            {
                Subsplits = new DataTable();
                Subsplits.Columns.Add("Name");
                ID = id;
                Name = name;
            }

            public Split(string name = "")
            {
                Subsplits = new DataTable();
                Subsplits.Columns.Add("Name");
                SplitIDCount++;
                ID = SplitIDCount;
                Name = name;
            }
            public DataTable Subsplits { get; set; }
            public int ID { get; set; }
            public string Name { get; set; }
        }

        private void ClearAll()
        {
            gridSplits.Rows.Clear();
            _splits.Clear();
            UpdateDataSource(gridSubsplits, null);
            _autoSplitterSettings = null;
        }

        private void RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
            ((DataGridView)sender).Rows[e.RowIndex].Selected = true;
        }

        private void gridSplits_RowStateChanged(object sender, EventArgs e)
        {
            if (gridSplits.SelectedRows.Count == 0) return;
            SubsplitsUpdateHighlight(GetCurSplitID);
        }

        private void gridSplits_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ((Split)_splits[e.RowIndex]).Name = gridSplits.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void SplitsAdd(Split split, bool createNew = false)
        {
            SplitIDCount++;
            split.ID = SplitIDCount;
            _splits.Add(SplitIDCount, split);
            gridSplits.Rows.Add(split.Name, SplitIDCount);

            if (createNew)
                split.Subsplits.Rows.Add($"");
            SubsplitsUpdateHighlight(GetCurSplitID);
        }

        private void butSplitsAdd_Click(object sender, EventArgs e)
        {
            SplitsAdd(new Split(SplitIDCount, ""), true);
            SubsplitsUpdateHighlight(GetCurSplitID);
        }
        private void butSplitsRemove_Click(object sender, EventArgs e)
        {
            if (_splits.Count == 0 || gridSplits.SelectedRows.Count == 0)
                return;

            int topMostIndex = int.MaxValue;

            foreach (DataGridViewRow i in gridSplits.SelectedRows)
            {
                if (i.Index - 1 < topMostIndex) topMostIndex = i.Index - 1;
                ((Split)_splits[i.Cells[1].Value]).Subsplits.Dispose();
                _splits.Remove((int)i.Cells[1].Value);
                gridSplits.Rows.Remove(i);
            }

            if (gridSplits.Rows.Count > 0 && topMostIndex >= 0)
                gridSplits.Rows[topMostIndex == 0 ? 0 : topMostIndex].Selected = true;
        }

        private void SubsplitsUpdateHighlight(int index)
        {
            UpdateDataSource(gridSubsplits, ((Split)_splits[(object)index]).Subsplits);
        }

        private void UpdateDataSource(DataGridView dgv, DataTable source)
        {
            int width = dgv.Size.Width - 3;
            dgv.DataSource = null;
            dgv.Columns.Clear();
            dgv.DataSource = source;
            if (source != null)
                dgv.Columns[0].Width = width;
            dgv.Invalidate();
        }

        private void butSubsplitsAdd_Click(object sender, EventArgs e)
        {
            if (_splits.Count == 0)
                return;

            GetCurSplit().Subsplits.Rows.Add("");
            SubsplitsUpdateHighlight(GetCurSplitID);
        }

        private void butSubsplitsRemove_Click(object sender, EventArgs e)
        {
            if (_splits.Count == 0 || gridSubsplits.SelectedRows.Count == 0)
                return;

            foreach (DataGridViewRow i in gridSubsplits.SelectedRows)
                GetCurSplit().Subsplits.Rows.RemoveAt(i.Index);

            UpdateDataSource(gridSubsplits, GetCurSplit().Subsplits);
        }

        private void butSplitsMove(bool moveUp = true)
        {
            if (gridSplits.SelectedRows.Count == 0) return;

            DataGridView dgv = gridSplits;

            int startSearchIndex = (moveUp) ? 0 : dgv.Rows.Count - 1;
            int move = (moveUp) ? -1 : +1;
            bool reverse = !moveUp;

            // generate the array of selected rows' indicies, used to determine how to move
            List<int> selRowIndicies = new List<int>();
            foreach (DataGridViewRow row in dgv.SelectedRows)
                selRowIndicies.Add(row.Index);

            // sort the indicies to decide the order we should sort, if reversed then reverse that array
            selRowIndicies.Sort();
            if (reverse) selRowIndicies.Reverse();

            // declare an array of moved indicies, used to determine how to swap data
            List<int> moved = new List<int>();

            foreach (int index in selRowIndicies)
            {
                if (index == startSearchIndex || moved.Contains(index + move))
                    moved.Add(index);
                else
                    moved.Add(index + move);

                Split old1 = (Split)_splits[index];
                Split old2 = (Split)_splits[moved[selRowIndicies.IndexOf(index)]];

                _splits[index] = old2;
                _splits[moved[selRowIndicies.IndexOf(index)]] = old1;

                gridSplits[0, index].Value = old2.Name;
                gridSplits[0, moved[selRowIndicies.IndexOf(index)]].Value = old1.Name;
            }

            dgv.ClearSelection();
            foreach (int i in moved)
                dgv.Rows[i].Selected = true;
        }

        private void butSubsplitsMove(bool moveUp = true)
        {
            if (gridSubsplits.SelectedRows.Count == 0) return;

            DataGridView dgv = gridSubsplits;
            DataTable dt = (DataTable)gridSubsplits.DataSource;

            int startSearchIndex = (moveUp) ? 0 : dt.Rows.Count - 1;
            int move = (moveUp) ? -1 : +1;
            bool reverse = !moveUp;

            // generate the array of selected rows' indicies, used to determine how to move
            List<int> selRowIndicies = new List<int>(); 
            foreach (DataGridViewRow row in dgv.SelectedRows)
                selRowIndicies.Add(row.Index);

            // sort the indicies to decide the order we should sort, if reversed then reverse that array
            selRowIndicies.Sort();
            if (reverse) selRowIndicies.Reverse();

            // declare an array of moved indicies, used to determine how to swap data
            List<int> moved = new List<int>();

            foreach (int index in selRowIndicies)
            {
                if (index == startSearchIndex || moved.Contains(index + move))
                    moved.Add(index);
                else 
                    moved.Add(index + move);

                object[] row = dt.Rows[index].ItemArray;
                var dtRow = dt.NewRow();
                dtRow.ItemArray = row;

                object[] row2 = dt.Rows[moved[selRowIndicies.IndexOf(index)]].ItemArray;
                var dtRow2 = dt.NewRow();
                dtRow2.ItemArray = row2;

                dt.Rows.RemoveAt(index);
                dt.Rows.InsertAt(dtRow2, index);
                dt.Rows.RemoveAt(moved[selRowIndicies.IndexOf(index)]);
                dt.Rows.InsertAt(dtRow, moved[selRowIndicies.IndexOf(index)]);
            }

            UpdateDataSource(dgv, dt);

            dgv.ClearSelection();
            foreach (int i in moved)
                dgv.Rows[i].Selected = true;
        }

        private void butSubsplitMoveDown_Click(object sender, EventArgs e)
        {
            butSubsplitsMove(false);
        }

        private void butSubsplitsMoveUp_Click(object sender, EventArgs e)
        {
            butSubsplitsMove(true);
        }

        private void butSplitsMoveUp_Click(object sender, EventArgs e)
        {
            butSplitsMove(true);
        }

        private void butSplitsMoveDown_Click(object sender, EventArgs e)
        {
            butSplitsMove(false);
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Livesplit Split Files | *.lss";
            dialog.DefaultExt = "lss";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Split[] splitArray = new Split[_splits.Values.Count];
                _splits.Values.CopyTo(splitArray, 0);

                Run run = new Run()
                {
                    GameName = boxGameName.Text,
                    CategoryName = boxCategory.Text,
                    Offset = boxOffset.Text,
                    Splits = splitArray,
                    AutoSplitterSettings = _autoSplitterSettings
                };

                _fileHanlder.Export(run, dialog.FileName);
            }
        }

        private void butLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Livesplit Split Files | *.lss";
            dialog.DefaultExt = "lss";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Run run = _fileHanlder.Import(dialog.FileName);
                ClearAll();

                boxGameName.Text = run.GameName;
                boxCategory.Text = run.CategoryName;
                boxOffset.Text = run.Offset;
                _autoSplitterSettings = run.AutoSplitterSettings;

                foreach (Split split in run.Splits)
                    SplitsAdd(split);
            }
        }

        private void butReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
