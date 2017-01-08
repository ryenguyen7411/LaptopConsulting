using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            IEnumerable<Pc.Pc> pcBuilds = ontology.PcBuilds;

            // Internal class, do not touch
            //PcHelper.CreatePcJson(pcBuilds);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new demo_track());
        }

        // Lop tao file PC ontology json
        internal class PcHelper
        {
            public static void CreatePcJson(IEnumerable<Pc.Pc> pcBuilds)
            {
                List<string> pcs = File.ReadAllLines(@"G:\Code\Playground\LogicalIncrements\pc.v2.owl").ToList();


                foreach (var pcBuild in pcBuilds)
                {
                    var pcName = "Pc" + GetInstanceCount("Pc");
                    pcs.Insert(pcs.Count - 1, $"ClassAssertion(:Pc :{pcName})");
                    if (pcBuild.Case != null)
                    {
                        Add(pcName, pcBuild.Case, "Case", pcs);
                    }
                    if (pcBuild.Cpu != null)
                    {
                        Add(pcName, pcBuild.Cpu, "Cpu", pcs);
                    }
                    if (pcBuild.Gpu != null)
                    {
                        Add(pcName, pcBuild.Gpu, "Gpu", pcs);
                    }
                    if (pcBuild.Hdd != null)
                    {
                        Add(pcName, pcBuild.Hdd, "Hdd", pcs);
                    }
                    if (pcBuild.Hsf != null)
                    {
                        Add(pcName, pcBuild.Hsf, "Hsf", pcs);
                    }
                    if (pcBuild.Mobo != null)
                    {
                        Add(pcName, pcBuild.Mobo, "Mobo", pcs);
                    }
                    if (pcBuild.Psu != null)
                    {
                        Add(pcName, pcBuild.Psu, "Psu", pcs);
                    }
                    if (pcBuild.Ram != null)
                    {
                        Add(pcName, pcBuild.Ram, "Ram", pcs);
                    }
                    if (pcBuild.Ssd != null)
                    {
                        Add(pcName, pcBuild.Ssd, "Ssd", pcs);
                    }
                    if (pcBuild.Tier != null)
                    {
                        Add(pcName, pcBuild.Tier, "Tier", pcs);
                    }
                }

                File.WriteAllLines(@"G:\Code\Playground\LogicalIncrements\extracted-pc.v2.owl", pcs);
            }

            private static readonly Dictionary<string, int> InstanceCounts = new Dictionary<string, int>();

            private static readonly Dictionary<string, string> InstanceWithNames = new Dictionary<string, string>();

            static int GetInstanceCount(string type)
            {
                if (!InstanceCounts.ContainsKey(type)) InstanceCounts[type] = 0;

                return ++InstanceCounts[type];
            }

            static void Add(string pcName, Pc.Part part, string type, List<string> laptop2)
            {
                string partName;
                if (InstanceWithNames.ContainsKey(part.Name))
                {
                    partName = InstanceWithNames[part.Name];
                }
                else
                {
                    partName = type + GetInstanceCount(type);
                    InstanceWithNames.Add(part.Name, partName);
                    laptop2.Insert(37, $"Declaration(NamedIndividual(:{partName}))");

                    laptop2.Insert(laptop2.Count - 1, $"ClassAssertion(:{type} :{partName})");
                    if (part.Description != null)
                        laptop2.Insert(laptop2.Count - 1,
                            $@"DataPropertyAssertion(:hasDescription :{partName} ""{part.Description.Replace("\"", "\\\"")}""^^xsd:string)");

                    if (part.Image != null)
                        laptop2.Insert(laptop2.Count - 1,
                            $@"DataPropertyAssertion(:hasImage :{partName} ""{part.Image.Replace("\"", "\\\"")}""^^xsd:string)");

                    if (part.Link != null)
                        laptop2.Insert(laptop2.Count - 1,
                            $@"DataPropertyAssertion(:hasLink :{partName} ""{part.Link.Replace("\"", "\\\"")}""^^xsd:string)");

                    if (part.Name != null)
                        laptop2.Insert(laptop2.Count - 1,
                            $@"DataPropertyAssertion(:hasName :{partName} ""{part.Name.Replace("\"", "\\\"")}""^^xsd:string)");

                    if (part.Price != null)
                        laptop2.Insert(laptop2.Count - 1,
                            $@"DataPropertyAssertion(:hasPrice :{partName} ""{part.Price}""^^xsd:decimal)");
                }

                laptop2.Insert(laptop2.Count - 1, $"ObjectPropertyAssertion(:has{type} :{pcName} :{partName})");
            }

            static void Add(string pcName, Pc.Tier tier, string type, List<string> laptop2)
            {
                string tierName;
                if (InstanceWithNames.ContainsKey(tier.Total.ToString()))
                {
                    tierName = InstanceWithNames[tier.Total.ToString()];
                }
                else
                {
                    tierName = type + GetInstanceCount(type);
                    InstanceWithNames.Add(tier.Total.ToString(), tierName);
                    laptop2.Insert(37, $"Declaration(NamedIndividual(:{tierName}))");

                    laptop2.Insert(laptop2.Count - 1, $@"ClassAssertion(:{type} :{tierName})");
                    if (tier.Description != null)
                        laptop2.Insert(laptop2.Count - 1,
                            $@"DataPropertyAssertion(:hasDescription :{tierName} ""{tier.Description.Replace("\"", "\\\"")}""^^xsd:string)");

                    if (tier.Image != null)
                        laptop2.Insert(laptop2.Count - 1,
                            $@"DataPropertyAssertion(:hasImage :{tierName} ""{tier.Image.Replace("\"", "\\\"")}""^^xsd:string)");

                    if (tier.Total != null)
                        laptop2.Insert(laptop2.Count - 1,
                            $@"DataPropertyAssertion(:hasTotal :{tierName} ""{tier.Total}""^^xsd:decimal)");
                }

                laptop2.Insert(laptop2.Count - 1, $"ObjectPropertyAssertion(:has{type} :{pcName} :{tierName})");
            }
        }
    }
}