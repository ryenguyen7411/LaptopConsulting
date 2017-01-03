using Laptop_Resuilt.Laptop;
using ontology_manager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Resuilt
{
    static class CoreSystem
    {
        public static List<m_laptop> laptop = new List<m_laptop>();
        public static OntologyManager manager;
        public static void init()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string pcPath = Path.Combine(currentDirectory, @"..\..\..\ontology_manager\Ontology\pc.v1.json");
            string laptopPath = Path.Combine(currentDirectory, @"..\..\..\ontology_manager\Ontology\laptop.v1.json");

            manager = new OntologyManager(pcPath, laptopPath);
        }

        public static void Load_Laptop()
        {
            for (int i = 0; i < manager.LaptopBuilds.Count(); i++)
            {
                //laptop[i]._cons=manager.
            }
        }

        public static string GetMiscValue(int laptopIndex)
        {
            //var _misces = manager.LaptopBuilds.

            return null;
        }


        public static void forward_chaining()
        {
            // for(int i=0;i<laptop)

        }




    }
}
