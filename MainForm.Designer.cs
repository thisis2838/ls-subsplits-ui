
namespace ls_subsplits_ui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gRunInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.boxCategory = new System.Windows.Forms.TextBox();
            this.labGameName = new System.Windows.Forms.Label();
            this.labCategory = new System.Windows.Forms.Label();
            this.boxGameName = new System.Windows.Forms.TextBox();
            this.boxOffset = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butSplitsRemove = new System.Windows.Forms.Button();
            this.butSubsplitsRemove = new System.Windows.Forms.Button();
            this.butSplitsMoveDown = new System.Windows.Forms.Button();
            this.butSplitsMoveUp = new System.Windows.Forms.Button();
            this.butSubsplitMoveDown = new System.Windows.Forms.Button();
            this.butSubsplitsMoveUp = new System.Windows.Forms.Button();
            this.butSubsplitsAdd = new System.Windows.Forms.Button();
            this.butSplitsAdd = new System.Windows.Forms.Button();
            this.labSubsplits = new System.Windows.Forms.Label();
            this.gridSubsplits = new System.Windows.Forms.DataGridView();
            this.ssName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labSplits = new System.Windows.Forms.Label();
            this.gridSplits = new System.Windows.Forms.DataGridView();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butSave = new System.Windows.Forms.Button();
            this.butLoad = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.gRunInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubsplits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplits)).BeginInit();
            this.SuspendLayout();
            // 
            // gRunInfo
            // 
            this.gRunInfo.Controls.Add(this.tableLayoutPanel1);
            this.gRunInfo.Location = new System.Drawing.Point(13, 13);
            this.gRunInfo.Name = "gRunInfo";
            this.gRunInfo.Size = new System.Drawing.Size(441, 107);
            this.gRunInfo.TabIndex = 0;
            this.gRunInfo.TabStop = false;
            this.gRunInfo.Text = "Run Info";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.21212F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.78788F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.boxCategory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labGameName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labCategory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.boxGameName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.boxOffset, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 78);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Timer at";
            // 
            // boxCategory
            // 
            this.boxCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxCategory.Location = new System.Drawing.Point(93, 29);
            this.boxCategory.Name = "boxCategory";
            this.boxCategory.Size = new System.Drawing.Size(333, 20);
            this.boxCategory.TabIndex = 3;
            // 
            // labGameName
            // 
            this.labGameName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labGameName.AutoSize = true;
            this.labGameName.Location = new System.Drawing.Point(3, 6);
            this.labGameName.Name = "labGameName";
            this.labGameName.Size = new System.Drawing.Size(66, 13);
            this.labGameName.TabIndex = 0;
            this.labGameName.Text = "Game Name";
            // 
            // labCategory
            // 
            this.labCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labCategory.AutoSize = true;
            this.labCategory.Location = new System.Drawing.Point(3, 32);
            this.labCategory.Name = "labCategory";
            this.labCategory.Size = new System.Drawing.Size(49, 13);
            this.labCategory.TabIndex = 1;
            this.labCategory.Text = "Category";
            // 
            // boxGameName
            // 
            this.boxGameName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxGameName.Location = new System.Drawing.Point(93, 3);
            this.boxGameName.Name = "boxGameName";
            this.boxGameName.Size = new System.Drawing.Size(333, 20);
            this.boxGameName.TabIndex = 2;
            // 
            // boxOffset
            // 
            this.boxOffset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxOffset.Location = new System.Drawing.Point(93, 55);
            this.boxOffset.Name = "boxOffset";
            this.boxOffset.Size = new System.Drawing.Size(111, 20);
            this.boxOffset.TabIndex = 5;
            this.boxOffset.Text = "00:00:00.000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butSplitsRemove);
            this.groupBox1.Controls.Add(this.butSubsplitsRemove);
            this.groupBox1.Controls.Add(this.butSplitsMoveDown);
            this.groupBox1.Controls.Add(this.butSplitsMoveUp);
            this.groupBox1.Controls.Add(this.butSubsplitMoveDown);
            this.groupBox1.Controls.Add(this.butSubsplitsMoveUp);
            this.groupBox1.Controls.Add(this.butSubsplitsAdd);
            this.groupBox1.Controls.Add(this.butSplitsAdd);
            this.groupBox1.Controls.Add(this.labSubsplits);
            this.groupBox1.Controls.Add(this.gridSubsplits);
            this.groupBox1.Controls.Add(this.labSplits);
            this.groupBox1.Controls.Add(this.gridSplits);
            this.groupBox1.Location = new System.Drawing.Point(13, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 326);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Splits";
            // 
            // butSplitsRemove
            // 
            this.butSplitsRemove.Location = new System.Drawing.Point(101, 16);
            this.butSplitsRemove.Name = "butSplitsRemove";
            this.butSplitsRemove.Size = new System.Drawing.Size(23, 23);
            this.butSplitsRemove.TabIndex = 11;
            this.butSplitsRemove.Text = "-";
            this.butSplitsRemove.UseVisualStyleBackColor = true;
            this.butSplitsRemove.Click += new System.EventHandler(this.butSplitsRemove_Click);
            // 
            // butSubsplitsRemove
            // 
            this.butSubsplitsRemove.Location = new System.Drawing.Point(351, 16);
            this.butSubsplitsRemove.Name = "butSubsplitsRemove";
            this.butSubsplitsRemove.Size = new System.Drawing.Size(23, 23);
            this.butSubsplitsRemove.TabIndex = 10;
            this.butSubsplitsRemove.Text = "-";
            this.butSubsplitsRemove.UseVisualStyleBackColor = true;
            this.butSubsplitsRemove.Click += new System.EventHandler(this.butSubsplitsRemove_Click);
            // 
            // butSplitsMoveDown
            // 
            this.butSplitsMoveDown.Location = new System.Drawing.Point(159, 16);
            this.butSplitsMoveDown.Name = "butSplitsMoveDown";
            this.butSplitsMoveDown.Size = new System.Drawing.Size(23, 23);
            this.butSplitsMoveDown.TabIndex = 9;
            this.butSplitsMoveDown.Text = "▼";
            this.butSplitsMoveDown.UseVisualStyleBackColor = true;
            this.butSplitsMoveDown.Click += new System.EventHandler(this.butSplitsMoveDown_Click);
            // 
            // butSplitsMoveUp
            // 
            this.butSplitsMoveUp.Location = new System.Drawing.Point(130, 16);
            this.butSplitsMoveUp.Name = "butSplitsMoveUp";
            this.butSplitsMoveUp.Size = new System.Drawing.Size(23, 23);
            this.butSplitsMoveUp.TabIndex = 8;
            this.butSplitsMoveUp.Text = "▲";
            this.butSplitsMoveUp.UseVisualStyleBackColor = true;
            this.butSplitsMoveUp.Click += new System.EventHandler(this.butSplitsMoveUp_Click);
            // 
            // butSubsplitMoveDown
            // 
            this.butSubsplitMoveDown.Location = new System.Drawing.Point(409, 16);
            this.butSubsplitMoveDown.Name = "butSubsplitMoveDown";
            this.butSubsplitMoveDown.Size = new System.Drawing.Size(23, 23);
            this.butSubsplitMoveDown.TabIndex = 7;
            this.butSubsplitMoveDown.Text = "▼";
            this.butSubsplitMoveDown.UseVisualStyleBackColor = true;
            this.butSubsplitMoveDown.Click += new System.EventHandler(this.butSubsplitMoveDown_Click);
            // 
            // butSubsplitsMoveUp
            // 
            this.butSubsplitsMoveUp.Location = new System.Drawing.Point(380, 16);
            this.butSubsplitsMoveUp.Name = "butSubsplitsMoveUp";
            this.butSubsplitsMoveUp.Size = new System.Drawing.Size(23, 23);
            this.butSubsplitsMoveUp.TabIndex = 6;
            this.butSubsplitsMoveUp.Text = "▲";
            this.butSubsplitsMoveUp.UseVisualStyleBackColor = true;
            this.butSubsplitsMoveUp.Click += new System.EventHandler(this.butSubsplitsMoveUp_Click);
            // 
            // butSubsplitsAdd
            // 
            this.butSubsplitsAdd.Location = new System.Drawing.Point(322, 16);
            this.butSubsplitsAdd.Name = "butSubsplitsAdd";
            this.butSubsplitsAdd.Size = new System.Drawing.Size(23, 23);
            this.butSubsplitsAdd.TabIndex = 5;
            this.butSubsplitsAdd.Text = "+";
            this.butSubsplitsAdd.UseVisualStyleBackColor = true;
            this.butSubsplitsAdd.Click += new System.EventHandler(this.butSubsplitsAdd_Click);
            // 
            // butSplitsAdd
            // 
            this.butSplitsAdd.Location = new System.Drawing.Point(72, 16);
            this.butSplitsAdd.Name = "butSplitsAdd";
            this.butSplitsAdd.Size = new System.Drawing.Size(23, 23);
            this.butSplitsAdd.TabIndex = 4;
            this.butSplitsAdd.Text = "+";
            this.butSplitsAdd.UseVisualStyleBackColor = true;
            this.butSplitsAdd.Click += new System.EventHandler(this.butSplitsAdd_Click);
            // 
            // labSubsplits
            // 
            this.labSubsplits.AutoSize = true;
            this.labSubsplits.Location = new System.Drawing.Point(185, 21);
            this.labSubsplits.Name = "labSubsplits";
            this.labSubsplits.Size = new System.Drawing.Size(49, 13);
            this.labSubsplits.TabIndex = 3;
            this.labSubsplits.Text = "Subsplits";
            // 
            // gridSubsplits
            // 
            this.gridSubsplits.AllowUserToAddRows = false;
            this.gridSubsplits.AllowUserToDeleteRows = false;
            this.gridSubsplits.AllowUserToResizeRows = false;
            this.gridSubsplits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridSubsplits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSubsplits.ColumnHeadersVisible = false;
            this.gridSubsplits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssName});
            this.gridSubsplits.Location = new System.Drawing.Point(188, 45);
            this.gridSubsplits.Name = "gridSubsplits";
            this.gridSubsplits.RowHeadersVisible = false;
            this.gridSubsplits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSubsplits.Size = new System.Drawing.Size(244, 266);
            this.gridSubsplits.TabIndex = 2;
            // 
            // ssName
            // 
            this.ssName.HeaderText = "Name";
            this.ssName.MinimumWidth = 241;
            this.ssName.Name = "ssName";
            this.ssName.Width = 241;
            // 
            // labSplits
            // 
            this.labSplits.AutoSize = true;
            this.labSplits.Location = new System.Drawing.Point(9, 21);
            this.labSplits.Name = "labSplits";
            this.labSplits.Size = new System.Drawing.Size(32, 13);
            this.labSplits.TabIndex = 1;
            this.labSplits.Text = "Splits";
            // 
            // gridSplits
            // 
            this.gridSplits.AllowUserToAddRows = false;
            this.gridSplits.AllowUserToResizeRows = false;
            this.gridSplits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSplits.ColumnHeadersVisible = false;
            this.gridSplits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sName,
            this.sID});
            this.gridSplits.Location = new System.Drawing.Point(12, 45);
            this.gridSplits.Name = "gridSplits";
            this.gridSplits.RowHeadersVisible = false;
            this.gridSplits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSplits.Size = new System.Drawing.Size(170, 266);
            this.gridSplits.TabIndex = 0;
            // 
            // sName
            // 
            this.sName.HeaderText = "Name";
            this.sName.MinimumWidth = 167;
            this.sName.Name = "sName";
            this.sName.Width = 167;
            // 
            // sID
            // 
            this.sID.HeaderText = "ID";
            this.sID.Name = "sID";
            this.sID.ReadOnly = true;
            this.sID.Visible = false;
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(379, 459);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 2;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butLoad
            // 
            this.butLoad.Location = new System.Drawing.Point(13, 459);
            this.butLoad.Name = "butLoad";
            this.butLoad.Size = new System.Drawing.Size(75, 23);
            this.butLoad.TabIndex = 3;
            this.butLoad.Text = "Load";
            this.butLoad.UseVisualStyleBackColor = true;
            this.butLoad.Click += new System.EventHandler(this.butLoad_Click);
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(94, 459);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(75, 23);
            this.butReset.TabIndex = 4;
            this.butReset.Text = "Reset";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 490);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.butLoad);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gRunInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Livesplit Subsplits Generator";
            this.gRunInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubsplits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gRunInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxCategory;
        private System.Windows.Forms.Label labGameName;
        private System.Windows.Forms.Label labCategory;
        private System.Windows.Forms.TextBox boxGameName;
        private System.Windows.Forms.TextBox boxOffset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labSubsplits;
        private System.Windows.Forms.DataGridView gridSubsplits;
        private System.Windows.Forms.Label labSplits;
        private System.Windows.Forms.DataGridView gridSplits;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssName;
        private System.Windows.Forms.Button butSubsplitsAdd;
        private System.Windows.Forms.Button butSplitsAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sID;
        private System.Windows.Forms.Button butSplitsMoveDown;
        private System.Windows.Forms.Button butSplitsMoveUp;
        private System.Windows.Forms.Button butSubsplitMoveDown;
        private System.Windows.Forms.Button butSubsplitsMoveUp;
        private System.Windows.Forms.Button butSubsplitsRemove;
        private System.Windows.Forms.Button butSplitsRemove;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butLoad;
        private System.Windows.Forms.Button butReset;
    }
}

