using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ontology_manager;
using ontology_manager.Pc;

namespace unit_test
{
    [TestClass]
    public class OntologyTest
    {
        [TestMethod]
        public void LoadOntology()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string pcPath = Path.Combine(currentDirectory, @"..\..\..\ontology_manager\Ontology\pc.v1.json");
            string laptopPath = Path.Combine(currentDirectory, @"..\..\..\ontology_manager\Ontology\laptop.v1.json");

            OntologyManager manager = new OntologyManager(pcPath, laptopPath);

            Assert.IsNotNull(manager);
            Assert.IsNotNull(manager.PcObjects);
            Assert.IsNotNull(manager.LaptopObjects);

            List<ontology_manager.Laptop.Object> laptopObjects = manager.LaptopObjects.Where(l => l.HasName != null).ToList();
            Assert.IsTrue(laptopObjects.Count > 0);

            // List<IList<HasValue>> pcObjects = manager.PcObjects.Where(pc => pc.HasValue != null).Select(pc => pc.HasValue).ToList();
        }
    }
}