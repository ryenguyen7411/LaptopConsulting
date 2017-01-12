using System.Collections.Generic;
using System.IO;
using System.Linq;
using Laptop_Resuilt.Laptop;
using ontology_manager;
using Newtonsoft.Json;

namespace Laptop_Resuilt
{
    static class Constants
    {
        public static readonly string PRICE = "prices";
        public static readonly string SCREENSIZE = "screensize";
        public static readonly string PROS = "pros";
        public static readonly string CONS = "cons";
        public static readonly string LENGTH = "length";
        public static readonly string WIDTH = "width";
        public static readonly string THICKNESS = "thickness";
        public static readonly string WEBCAM = "webcamquality";
        public static readonly string CPU = "cpu";
        public static readonly string GPU = "gpu";
        public static readonly string GPUDescription = "gpudescription";
        public static readonly string CPUDescription = "cpudescription";
        public static readonly string RAM = "ram";
        public static readonly string STORAGE = "storage";
        public static readonly string PANEL_TYPE = "paneltypeipsortn";
        public static readonly string PANELCOATING = "panelcoatingglossyantiglarematte";
        public static readonly string SCREEN_RESOLUTION = "screenresolution";
        public static readonly string OPERATING_SYSTEM = "operatingsystem";
        public static readonly string COLOR = "colours";
        public static readonly string WEIGHT = "weightlbs";
        public static readonly string CAPACITY = "batteryheavy";
        public static readonly string LONG_DECRIPTION = "longdesc";
    }

    public partial class PriceParser
    {
        public string price;
        public string title;
        public string url;
    }

    public static class CoreSystem
    {
        public static List<m_laptop> laptop = new List<m_laptop>();
        public static OntologyManager manager;

        public static void init()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string pcPath = Path.Combine(currentDirectory, @"..\..\..\ontology_manager\Ontology\pc.v1.jsonld");
            string laptopPath = Path.Combine(currentDirectory, @"..\..\..\ontology_manager\Ontology\laptop.v1.jsonld");

            manager = new OntologyManager(pcPath, laptopPath);

            Load_Laptop();
        }

        public static void Load_Laptop()
        {
            for (int i = 0; i < manager.LaptopBuilds.Count(); i++)
            {
                m_laptop new_laptop = new m_laptop();
                new_laptop._name = get_name(i);
                new_laptop._outside._operatingSystem = GetMiscValue(i, Constants.OPERATING_SYSTEM);
                new_laptop._outside._weight = GetMiscValue(i, Constants.WEIGHT);
                new_laptop._outside._color = GetMiscValue(i, Constants.COLOR);
                new_laptop._outside._length = GetMiscValue(i, Constants.LENGTH);
                new_laptop._outside._width = GetMiscValue(i, Constants.WIDTH);
                new_laptop._outside._panelCoating = GetMiscValue(i, Constants.PANELCOATING);
                new_laptop._outside.thickness = GetMiscValue(i, Constants.THICKNESS);

                string _price = GetMiscValue(i, Constants.PRICE);

                if (_price != null)
                {
                    var obj = JsonConvert.DeserializeObject<IEnumerable<PriceParser>>(_price);
                    new_laptop._outside.price = obj.ElementAt(0).price;
                }

                new_laptop._gpu.m_decription = GetMiscValue(i, Constants.GPUDescription);
                new_laptop._gpu.m_name = GetMiscValue(i, Constants.GPU);


                new_laptop._cpu._decriptionCPU = GetMiscValue(i, Constants.CPUDescription);
                new_laptop._cpu.m_name = GetMiscValue(i, Constants.CPU);
                new_laptop._cpu.m_ram = GetMiscValue(i, Constants.RAM);

                new_laptop._screen._screenResolution = GetMiscValue(i, Constants.SCREEN_RESOLUTION);
                new_laptop._screen._screenSize = GetMiscValue(i, Constants.SCREENSIZE);

                new_laptop._battery._capacity = GetMiscValue(i, Constants.CAPACITY);

                new_laptop._cons = GetMiscValue(i, Constants.CONS);
                new_laptop._pros = GetMiscValue(i, Constants.PROS);

                new_laptop._detail_decription = GetMiscValue(i, Constants.LONG_DECRIPTION);

                laptop.Add(new_laptop);

            }
        }
        public static string get_name(int laptopIndex)
        {
            var _name = manager.LaptopBuilds.ElementAt(laptopIndex).HasName;
            if (_name == null)
            {
                return null;
            }
            return _name[0].Value;

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
        public static bool matched(Dictionary<string, string> Known, m_laptop _laptop) // bộ so khớp
        {
            // so sánh sự kiện trong Known với laptop;
            for (int i = 0; i < Known.Count; i++)
            {
                KeyValuePair<string, string> _element = Known.ElementAt(i);

                if (IsEqual(_element.Key, Constants.RAM))
                {
                    if(StringToFloat(_element.Value) > StringToFloat(_laptop._cpu.m_ram))
                        return false;
                }

                if (IsEqual(_element.Key, Constants.CPU) && !IsContains(_laptop._cpu.m_name, _element.Value))
                {
                    return false;
                }

                if (IsEqual(_element.Key, Constants.SCREENSIZE))
                {
                    if(StringToFloat(_element.Value) > StringToFloat(_laptop._screen._screenSize))
                        return false;
                }

                if (IsEqual(_element.Key, Constants.GPU) && !IsContains(_laptop._gpu.m_name, _element.Value))
                {
                    return false;
                }

                if (IsEqual(_element.Key, Constants.STORAGE + "_type") && !IsContains(_laptop.storage, _element.Value))
                {
                    return false;
                }

                if(IsEqual(_element.Key, Constants.STORAGE + "_value"))
                {
                    if (StringToFloat(_element.Value) > StringToFloat(_laptop.storage))
                        return false;
                }

                float OFFSET = 50;
                if(IsEqual(_element.Key, Constants.PRICE + "_min"))
                {
                    float element = StringToFloat(_element.Value);
                    float laptop = StringToFloat(_laptop._outside.price);
                    if (StringToFloat(_element.Value) - OFFSET > StringToFloat(_laptop._outside.price))
                    {
                        return false;
                    }
                }

                if (IsEqual(_element.Key, Constants.PRICE + "_max"))
                {
                    float element = StringToFloat(_element.Value);
                    float laptop = StringToFloat(_laptop._outside.price);
                    if (StringToFloat(_element.Value) + OFFSET < StringToFloat(_laptop._outside.price))
                    {
                        return false;
                    }
                }
            }

            return true;
        }


        public static Dictionary<int, m_laptop> ForwardChaining(Dictionary<string, string> inputs)
        {
            // khởi tạo Known
            Dictionary<string, string> Known = inputs;
            Dictionary<int, m_laptop> output = new Dictionary<int, m_laptop>();

            for (int i = 0; i < laptop.Count; i++)
            {
                if (matched(Known, laptop[i]))
                {
                    output.Add(i, laptop[i]);
                }
            }

            return output;
        }

        public static bool IsEqual(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                return false;
            return str1.CompareTo(str2) == 0;
        }

        public static bool IsContains(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                return false;

            return str1.Contains(str2);
        }

        public static float StringToFloat(string str)
        {
            if (str == null)
                return 0;

            float _value = 0;

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == '"')
                    continue;

                if (str[i] == '.')
                    continue;

                if (str[i] < '0' || str[i] > '9')
                    break;

                if(i > 0 && str[i] - 1 == '.')
                {
                    _value += 10.0f / (str[i] - '0');
                }
                else if(str[i] != '.')
                {
                    _value *= 10;
                    _value += str[i] - '0';
                }
            }

            return _value;
        }
    }
}