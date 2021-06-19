using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static ls_subsplits_ui.MainForm;

namespace ls_subsplits_ui
{
    class FileHandler
    {
        public class Run
        {
            public string GameName { get; set; }
            public string CategoryName { get; set; }
            public string Offset { get; set; }
            public Split[] Splits { get; set; }
            public XmlNode AutoSplitterSettings { get; set; }
        }

        public void Export(Run run, string filePath)
        {
            if (run.Splits.Count() == 0)
                return;

            var document = new XmlDocument();

            XmlNode docNode = document.CreateXmlDeclaration("1.0", "UTF-8", null);
            document.AppendChild(docNode);

            var parent = document.CreateElement("Run");
            parent.Attributes.Append(XMLExtensions.ToAttribute(document, "version", "1.7.0"));
            document.AppendChild(parent);

            XMLExtensions.CreateEmptySetting(document, parent, "GameIcon");
            XMLExtensions.CreateSetting(document, parent, "GameName", run.GameName);
            XMLExtensions.CreateSetting(document, parent, "CategoryName", run.CategoryName);
            XMLExtensions.CreateSetting(document, parent, "Offset", string.IsNullOrEmpty(run.Offset) ? "00:00:00" : run.Offset);
            XMLExtensions.CreateSetting(document, parent, "AttemptCount", 0);
            XMLExtensions.CreateEmptySetting(document, parent, "AttemptHistory");

            var segmentElement = document.CreateElement("Segments");
            parent.AppendChild(segmentElement);

            foreach (var segment in run.Splits)
            {
                if (segment.Subsplits.Rows.Count == 0)
                {
                    var splitElement = document.CreateElement("Segment");
                    segmentElement.AppendChild(splitElement);
                    XMLExtensions.CreateSetting(document, splitElement, "Name", segment.Name);
                    continue;
                }

                for (int i = 0; i < segment.Subsplits.Rows.Count; i++)
                {
                    var splitElement = document.CreateElement("Segment");
                    segmentElement.AppendChild(splitElement);

                    DataRow subSegment = segment.Subsplits.Rows[i];
                    string name = (i < segment.Subsplits.Rows.Count - 1)
                        ? $"-{subSegment[0]}"
                        : $"{{{segment.Name}}} {subSegment[0]}";

                    XMLExtensions.CreateSetting(document, splitElement, "Name", name);
                }
            }

            document.DocumentElement.AppendChild(document.ImportNode(run.AutoSplitterSettings, true));
            document.Save(filePath);
        }

        public Run Import(string filePath)
        {
            XmlDocument document = new XmlDocument();
            document.Load(filePath);

            var parent = document.DocumentElement.ChildNodes;
            Run run = new Run();
            foreach (XmlNode node in parent)
            {
                switch (node.Name)
                {
                    case "GameName":
                        run.GameName = node.InnerText;
                        break;
                    case "CategoryName":
                        run.CategoryName = node.InnerText;
                        break;
                    case "Offset":
                        run.Offset = node.InnerText;
                        break;
                    case "AutoSplitterSettings":
                        run.AutoSplitterSettings = node;
                        break;
                    case "Segments":
                        {
                            List<string> splitNames = new List<string>();
                            List<string> subSplitNames = new List<string>();
                            List<Split> splits = new List<Split>();
                            foreach (XmlNode segmentNode in node)
                                splitNames.Add(segmentNode["Name"].InnerText);

                            for (int i = 0; i < splitNames.Count; i++)
                            {
                                if (!splitNames[i].Trim().StartsWith("-"))
                                    splits.Add(new Split(splitNames[i]));
                                else
                                {
                                    var tempSplit = new Split("");
                                    while (i < splitNames.Count)
                                    {
                                        if (splitNames[i].Trim().StartsWith("-"))
                                            subSplitNames.Add(splitNames[i].TrimStart('-'));
                                        else
                                        {
                                            string tmp = splitNames[i].Trim();
                                            string splitName = tmp;
                                            string finalSubsplitName = splitName;

                                            if (tmp.Contains('{') && tmp.Contains('}'))
                                            {
                                                string[] names = tmp.Split('{', '}');
                                                splitName = names[1].Trim();
                                                finalSubsplitName = names[2].Trim();
                                            }

                                            tempSplit.Name = splitName;
                                            subSplitNames.Add(finalSubsplitName);

                                            foreach (string subSplitName in subSplitNames)
                                                tempSplit.Subsplits.Rows.Add(subSplitName);

                                            splits.Add(tempSplit);
                                            break;
                                        }
                                        i++;
                                    }

                                }
                                subSplitNames = new List<string>();
                            }

                            run.Splits = splits.ToArray();
                            break;
                        }

                }
            }
            return run;
        }
    }

    class XMLExtensions
    {
        public static XmlAttribute ToAttribute<T>(XmlDocument document, string name, T value)
        {
            var element = document.CreateAttribute(name);
            element.Value = value?.ToString();
            return element;
        }
        public static int CreateSetting<T>(XmlDocument document, XmlElement parent, string name, T value)
        {
            if (document != null)
            {
                var element = document.CreateElement(name);
                element.InnerText = value?.ToString();
                parent.AppendChild(element);
            }
            return value != null ? value.GetHashCode() : 0;
        }

        public static void CreateEmptySetting(XmlDocument document, XmlElement parent, string name)
        {
            if (document != null)
            {
                var element = document.CreateElement(name);
                parent.AppendChild(element);
            }
        }
    }
}
