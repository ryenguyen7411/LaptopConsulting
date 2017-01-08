using System;
using System.Windows.Forms;
using Laptop_Resuilt;

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
            var pcBuilds = ontology.PcBuilds;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new demo_track());
        }
    }
}