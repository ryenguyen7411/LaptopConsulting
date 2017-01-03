using System.Collections.Generic;
using System.IO;
using System.Linq;
using Laptop_Resuilt.Laptop;
using ontology_manager;

namespace Laptop_Resuilt
{
    static class CoreSystem
    {
        public static List<m_laptop> laptop = new List<m_laptop>();
        public static OntologyManager manager;
        const  string PRICE = "prices";
        const string SCREENSIZE = "screensize";
        const string PROS = "pros";
        const string CONS= "cons";
        const string LENGTH = "length";
        const string WIDTH = "width";
        const string THICKNESS = "thickness";
        const string WEBCAM = "webcamquality";
        const string CPU = "cpu";
        const string GPU = "gpu";
        const string GPUDescription = "gpudescription";
        const string CPUDescription = "cpudescription";
        const string RAM = "ram";
        const string STORAGE = "storage";
        const string PANEL_TYPE = "paneltypeipsortn";
        const string PANELCOATING = "panelcoatingglossyantiglarematte";
        const string SCREEN_RESOLUTION = "screenresolution";
        const string OPERATING_SYSTEM = "operatingsystem";
        const string COLOR = "colours";
        const string WEIGHT = "weightlbs";
        const string CAPACITY = "batteryheavy";
        const string LONG_DECRIPTION = "longdesc";
       
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
                m_laptop new_laptop = new m_laptop();
                new_laptop._name = get_name(i);
                new_laptop._outside._operatingSystem = GetMiscValue(i, OPERATING_SYSTEM);
                new_laptop._outside._weight = GetMiscValue(i, WEIGHT);
                new_laptop._outside._color = GetMiscValue(i, COLOR);
                new_laptop._outside._length = GetMiscValue(i, LENGTH);
                new_laptop._outside._width = GetMiscValue(i, WIDTH);
                new_laptop._outside._panelCoating = GetMiscValue(i, PANELCOATING);
                new_laptop._outside.thickness = GetMiscValue(i, THICKNESS);
                new_laptop._outside.price = GetMiscValue(i, PRICE);

                new_laptop._gpu.m_decription = GetMiscValue(i, GPUDescription);
                new_laptop._gpu.m_name = GetMiscValue(i, GPU);


                new_laptop._cpu._decriptionCPU = GetMiscValue(i, CPUDescription);
                new_laptop._cpu.m_name = GetMiscValue(i, CPU);
                new_laptop._cpu.m_ram = GetMiscValue(i, RAM);

                new_laptop._screen._screenResolution = GetMiscValue(i, SCREEN_RESOLUTION);

                new_laptop._battery._capacity = GetMiscValue(i, CAPACITY);

                new_laptop._cons = GetMiscValue(i, CONS);
                new_laptop._pros = GetMiscValue(i, PROS);

                new_laptop._detail_decription = GetMiscValue(i, LONG_DECRIPTION);

                laptop.Add(new_laptop);
                
            }
        }
        public static string get_name(int laptopIndex)
        {
            var _name = manager.LaptopBuilds.ElementAt(laptopIndex).HasName;
            if ( _name==null)
            {
                return null;
            }
           return  _name[0].Value;
            
          //  return null;
        }

        public static string GetMiscValue(int laptopIndex, string miscTitle)
        {
            var _misces = manager.LaptopBuilds.ElementAt(laptopIndex).HasMisc;

            if (_misces == null)
                return null;

            for (int i = 0; i < _misces.Count(); i++)
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
        public static int matched( List<string> Known,m_laptop laptop) // bộ so khớp
        {
            int count = 0; // số sự kiện khớp
            // so sánh sự kiện trong Known với laptop;
            return count;

         //   for ( int i =0;i<)
        }


        public static void forward_chaining(List<string>Input)// bộ suy diễn
        {
            // khởi tạo Known
            List<string> Known = new List<string>();
            List<m_laptop> Output = new List<m_laptop>();
            for (int i = 0; i < Input.Count; i++)
            {
                Known.Add(Input[i]);

            }

            // duyệt tập luật được lưu

            for (int i = 0; i < laptop.Count; i++)
            {
                if (matched(Known,laptop[i])>0)
                {
                    Output.Add(laptop[i]);
                }
            }

        }


    }
}