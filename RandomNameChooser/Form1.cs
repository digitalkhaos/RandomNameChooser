using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RandomNameChooser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            const string path = @"c:\rnc_list";

            try
            {
                var lines = new List<string>();

                using (var streamReader = new StreamReader(path, Encoding.UTF8))
                {
                    string line;

                    while ((line = streamReader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }

                /*
                while((line = streamReader.ReadLine()) != null)
                {
                    foreach(line in streamReader)
                        NameEntry entry = new NameEntry(line);   
                }
                */
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

           


        }
        
        NameEntry entry1 = new NameEntry("John");

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(entry1.Name);
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {

        }

#pragma warning disable IDE1006 // Naming Styles
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {

        }

#pragma warning disable IDE1006 // Naming Styles
        private void aboutToolStripMenuItemAbout_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {

        }
    }
}