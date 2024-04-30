using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ReplaceNewSpot {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            string firstFilePath = mainFileTxt.Text;
            string secondFilePath = basePath + JoinFileTxt.Text;

            // Check if files exist
            if (!File.Exists(firstFilePath)) {
                textOut.Text = ($"Error: File {firstFilePath} not found.\n");
                return;
            }

            if (!File.Exists(secondFilePath)) {
                textOut.Text = ($"Error: File {secondFilePath} not found.\n");
                return;
            }


            // Load XML from files
            XDocument firstDoc = XDocument.Load(firstFilePath);
            XDocument secondDoc = XDocument.Load(secondFilePath);

            // Perform comparison and replacement
            ReplaceSpots(firstDoc, secondDoc);

            firstDoc.Save("out.xml");
            textOut.Text = "File saved as out.xml";
        }

        static void ReplaceSpots(XDocument firstDoc, XDocument secondDoc) {
            // Select all spawn elements from the first file
            var firstSpawns = firstDoc.Descendants("spawn");

            // For each spawn element from the second file
            foreach (var secondSpawn in secondDoc.Descendants("spawn")) {
                // Find the corresponding spawn element in the first file by npc_id
                var matchingSpawn = firstSpawns.FirstOrDefault(s =>
                    s.Attribute("npc_id")?.Value == secondSpawn.Attribute("npc_id")?.Value);

                // If such spawn is found, replace all spot elements
                if (matchingSpawn != null) {
                    matchingSpawn.ReplaceNodes(secondSpawn.Elements("spot"));
                } else {
                    // If spawn is not found in the first file, add the entire block to the <spawn_map> element in the first document
                    firstDoc.Root?.Element("spawn_map")?.Add(secondSpawn);

                }
            }
        }
    }
}
