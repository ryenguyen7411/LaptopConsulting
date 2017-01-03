using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ontology_manager;

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
            
        }

       
    }
}