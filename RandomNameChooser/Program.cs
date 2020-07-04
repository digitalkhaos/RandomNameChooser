using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNameChooser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            const string path = @"c:\rnc_list";

            try
            {
                var nameList = File.Create(path);
                var delimiter = "\r\n";
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            


        }
    }
}
