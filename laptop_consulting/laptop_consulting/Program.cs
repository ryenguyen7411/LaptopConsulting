using System;
using System.Windows.Forms;
using ontology_manager.Laptop;
using ontology_manager;
using System.IO;

namespace Laptop_Resuilt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ontology ontology = new Ontology();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}