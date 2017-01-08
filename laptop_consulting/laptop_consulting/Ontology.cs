using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Laptop_Resuilt.Pc;
using ontology_manager;

namespace Laptop_Resuilt
{
    public class Ontology
    {
        public IEnumerable<Pc.Pc> PcBuilds { get; private set; }

        public Ontology()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string pcPath = Path.Combine(currentDirectory, @"..\..\..\ontology_manager\Ontology\pc.v1.json");
            string laptopPath = Path.Combine(currentDirectory, @"..\..\..\ontology_manager\Ontology\laptop.v1.json");
            var manager = new OntologyManager(pcPath, laptopPath);

            PcBuilds = LoadPcBuilds(manager.PcBuilds);
        }

        private IEnumerable<Pc.Pc> LoadPcBuilds(IEnumerable<string> pcBuilds)
        {
            if (!pcBuilds.Any()) return null;

            List<Pc.Pc> builds = new List<Pc.Pc>();
            foreach (string pcBuild in pcBuilds)
            {
                Pc.Pc build = new Pc.Pc();

                if (pcBuild.Contains("tierimage: "))
                {
                    build.Tier = new Tier
                    {
                        Image = pcBuild.Between("tierimage: ", ", tierdesc: "),
                        Description = pcBuild.Between("tierdesc: ", ", gpu: ")
                    };
                }
                else build.Tier = builds.Last().Tier;

                string pcBuild2 = pcBuild;
                build.Gpu = (Gpu) GetPcPart(ref pcBuild2, builds, "gpu");
                build.Cpu = (Cpu) GetPcPart(ref pcBuild2, builds, "cpu");
                build.Hsf = (Hsf) GetPcPart(ref pcBuild2, builds, "hsf");
                build.Mobo = (Mobo) GetPcPart(ref pcBuild2, builds, "mobo");
                build.Ram = (Ram) GetPcPart(ref pcBuild2, builds, "ram");
                build.Hdd = (Hdd) GetPcPart(ref pcBuild2, builds, "hdd");
                build.Ssd = (Ssd) GetPcPart(ref pcBuild2, builds, "ssd");
                build.Psu = (Psu) GetPcPart(ref pcBuild2, builds, "psu");
                build.Case = (Case) GetPcPart(ref pcBuild2, builds, "case");

                if (pcBuild.Contains("total: "))
                {
                    if (pcBuild.Contains("lastupdated: "))
                        build.Total = Convert.ToDecimal(pcBuild.Between("total: ", ", lastupdated: "));
                    else
                        build.Total = Convert.ToDecimal(pcBuild.Substring(pcBuild.IndexOf("total: ") + 7));
                }
                if (build.Total == 0)
                {
                    build.Total = builds.Last().Total;
                }

                builds.Add(build);
            }


            return builds.OrderBy(b => b.Total);
        }

        private Part GetPcPart(ref string pcBuild, List<Pc.Pc> builds, string part)
        {
            Part pcPart = null;
            Part previousPart = null;

            string endString = $", {part}";
            string endNextString = ", ";
            if (part == "gpu")
            {
                pcPart = new Gpu();
                if (builds.Any())
                    previousPart = builds.Last().Gpu;
                if (pcBuild.Contains("cpu: "))
                    endNextString += "cpu: ";
                else if (pcBuild.Contains("hsf: "))
                    endNextString += "hsf: ";
                else if (pcBuild.Contains("mobo: "))
                    endNextString += "mobo: ";
            }
            else if (part == "cpu")
            {
                pcPart = new Cpu();
                if (builds.Any()) previousPart = builds.Last().Cpu;
                if (pcBuild.Contains("hsf: "))
                    endNextString += "hsf: ";
                else if (pcBuild.Contains("mobo: "))
                    endNextString += "mobo: ";
            }
            else if (part == "hsf")
            {
                pcPart = new Hsf();
                if (builds.Any()) previousPart = builds.Last().Hsf;
                endNextString += "mobo: ";
            }
            else if (part == "mobo")
            {
                pcPart = new Mobo();
                if (builds.Any()) previousPart = builds.Last().Mobo;
                if (pcBuild.Contains("ram: "))
                    endNextString += "ram: ";
                else if (pcBuild.Contains("hdd: "))
                    endNextString += "hdd: ";
            }
            else if (part == "ram")
            {
                pcPart = new Ram();
                if (builds.Any()) previousPart = builds.Last().Ram;
                endNextString += "hdd: ";
            }
            else if (part == "hdd")
            {
                pcPart = new Hdd();
                if (builds.Any()) previousPart = builds.Last().Hdd;
                endNextString += "ssd: ";
            }
            else if (part == "ssd")
            {
                pcPart = new Ssd();
                if (builds.Any()) previousPart = builds.Last().Ssd;
                endNextString += "psu: ";
            }
            else if (part == "psu")
            {
                pcPart = new Psu();
                if (builds.Any()) previousPart = builds.Last().Psu;
                if (pcBuild.Contains("case: "))
                    endNextString += "case: ";
                else if (pcBuild.Contains("total: "))
                    endNextString += "total: ";
            }
            else if (part == "case")
            {
                pcPart = new Case();
                if (builds.Any()) previousPart = builds.Last().Case;
                endNextString += "total: ";
            }

            if (pcBuild.Contains($"{part}"))
            {
                pcPart.Name = pcBuild.Between($"{part}: ", endString);
                pcBuild = pcBuild.Substring(pcBuild.IndexOf(endString, StringComparison.Ordinal)).Substring(4);
                if (pcBuild.Contains($"{part}price: "))
                {
                    pcPart.Price = Convert.ToDecimal(pcBuild.Between($"{part}price: ", endString));
                    pcBuild = pcBuild.Substring(pcBuild.IndexOf(endString, StringComparison.Ordinal)).Substring(4);
                }
                if (pcBuild.Contains($"{part}link: "))
                {
                    pcPart.Link = pcBuild.Between($"{part}link: ", endString);
                    pcBuild = pcBuild.Substring(pcBuild.IndexOf(endString, StringComparison.Ordinal)).Substring(4);
                }
                if (pcBuild.Contains($"{part}image: "))
                {
                    pcPart.Image = pcBuild.Between($"{part}image: ", endString);
                    pcBuild = pcBuild.Substring(pcBuild.IndexOf(endString, StringComparison.Ordinal)).Substring(4);
                }
                if (pcBuild.Contains($"{part}desc: "))
                {
                    pcPart.Description = pcBuild.Between($"{part}desc: ", endNextString);
                    if (pcPart.Description == null)
                    {
                        pcPart.Description = pcBuild.Substring(pcBuild.IndexOf($"{part}desc: "));
                    }
                }
                else
                {
                    throw new Exception();
                }
            }

            else pcPart = previousPart;

            return pcPart;
        }
    }
}