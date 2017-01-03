using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace ontology_manager
{
    public class OntologyManager
    {
        public IEnumerable<Laptop.Object> LaptopBuilds { get; private set; }

        public IEnumerable<string> PcBuilds { get; private set; }

        public OntologyManager(string pcFilePath, string laptopFilePath)
        {
            string pcJson = File.ReadAllText(pcFilePath);
            var pcObjects = JsonConvert.DeserializeObject<IEnumerable<Pc.Object>>(pcJson);

            // Temporary workaround: Currently cannot get all PC builds
            var pcBuilds = new List<string>();
            foreach (var hasValues in pcObjects.Where(pc => pc.HasValue != null).Select(pc => pc.HasValue))
            {
                pcBuilds.AddRange(
                    hasValues.Where(hv => hv.Value != null && hv.Value.Contains("cpu:")).Select(v => v.Value));
            }
            PcBuilds = pcBuilds;

            string laptopJson = File.ReadAllText(laptopFilePath);
            var laptopObjects = JsonConvert.DeserializeObject<IEnumerable<Laptop.Object>>(laptopJson);
            LaptopBuilds = laptopObjects.Where(l => l.HasName != null);
        }
    }
}