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

            Load_Laptop();
        }

        public static void Load_Laptop()
        {
            for (int i = 0; i < manager.LaptopBuilds.Count(); i++)
            {
                //laptop[i]._cons = GetMiscValue(i, )
                string s = GetMiscValue(i, "operatingsystem");
            }
        }

        public static string GetMiscValue(int laptopIndex, string miscTitle)
        {
            var _misces = manager.LaptopBuilds.ElementAt(laptopIndex).HasMisc;

            for(int i = 0; i < _misces.Count(); i++)
            {
                var valueMisc = manager.LaptopObjects.Where(l => l.Id == _misces[i].Id).First();
                var title = valueMisc.HasTitle.First().Value;

                if (title.CompareTo(miscTitle) == 0)
                {
                    return valueMisc.HasDesc.First().Value;
                }
            }

            return null;
        }


        public static void forward_chaining()
        {
            // for(int i=0;i<laptop)

        }




    }
}
