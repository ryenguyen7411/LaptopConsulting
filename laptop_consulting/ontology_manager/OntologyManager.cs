using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ontology_manager
{
    public class OntologyManager
    {
        public IEnumerable<Laptop.Object> LaptopObjects { get; private set; }

        public IEnumerable<Pc.Object> PcObjects { get; private set; }

        public OntologyManager(string pcFilePath, string laptopFilePath)
        {
            string pcJson = File.ReadAllText(pcFilePath);
            PcObjects = JsonConvert.DeserializeObject<IEnumerable<Pc.Object>>(pcJson);

            string laptopJson = File.ReadAllText(laptopFilePath);
            LaptopObjects = JsonConvert.DeserializeObject<IEnumerable<Laptop.Object>>(laptopJson);
        }
    }
}