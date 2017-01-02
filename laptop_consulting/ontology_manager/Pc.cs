using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ontology_manager
{
    namespace Pc
    {
        public class List
        {
            [JsonProperty("@id")]
            public string Id { get; set; }
        }

        public class UnionOf
        {
            [JsonProperty("@list")]
            public IList<List> List { get; set; }
        }

        public class HasScheme
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasTerm
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasType
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasValue
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasCategory
        {
            [JsonProperty("@id")]
            public string Id { get; set; }
        }

        public class HasContent
        {
            [JsonProperty("@id")]
            public string Id { get; set; }
        }

        public class HasLink
        {
            [JsonProperty("@id")]
            public string Id { get; set; }
        }

        public class HasTitle
        {
            [JsonProperty("@id")]
            public string Id { get; set; }
        }

        public class HasHref
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasRel
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasCase
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class Domain
        {
            [JsonProperty("@id")]
            public string Id { get; set; }
        }

        public class Range
        {
            [JsonProperty("@id")]
            public string Id { get; set; }
        }

        public class HasCasedesc
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasCaseimage
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasCaselink
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasCaseprice
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasCpu
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasCpudesc
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasCpuimage
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasCpulink
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasCpuprice
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasGpu
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasGpudesc
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasGpuimage
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasGpulink
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasGpuprice
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasHdd
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasHdddesc
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasHddimage
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasHddlink
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasHddprice
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasHsf
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasHsfdesc
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasHsfimage
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasHsflink
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasHsfprice
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasId
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasLastupdated
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasMobo
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasMobodesc
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasMoboimage
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasMobolink
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasMoboprice
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasPsu
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasPsudesc
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasPsuimage
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasPsulink
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasPsuprice
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasRam
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasRamdesc
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasRamimage
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasRamlink
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasRamprice
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasSsd
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasSsddesc
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasSsdimage
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasSsdlink
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasSsdprice
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasTier
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasTierdesc
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasTierimage
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasTotal
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasUpdated
        {
            [JsonProperty("@value")]
            public DateTime Value { get; set; }
        }

        public class Object
        {
            [JsonProperty("@id")]
            public string Id { get; set; }

            [JsonProperty("@type")]
            public IList<string> Type { get; set; }

            [JsonProperty("http://www.w3.org/2002/07/owl#unionOf")]
            public IList<UnionOf> UnionOf { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasScheme")]
            public IList<HasScheme>
                HasScheme { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasTerm")]
            public IList<HasTerm>
                HasTerm { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasType")]
            public IList<HasType>
                HasType { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasValue")]
            public IList<HasValue>
                HasValue { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasCategory")]
            public IList<HasCategory>
                HasCategory { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasContent")]
            public IList<HasContent>
                HasContent { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasLink")]
            public IList<HasLink>
                HasLink { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasTitle")]
            public IList<HasTitle>
                HasTitle { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasHref")]
            public IList<HasHref>
                HasHref { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasRel")]
            public IList<HasRel>
                HasRel { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasCase")]
            public IList<HasCase>
                HasCase { get; set; }

            [JsonProperty("http://www.w3.org/2000/01/rdf-schema#domain")]
            public IList<Domain> Domain { get; set; }

            [JsonProperty("http://www.w3.org/2000/01/rdf-schema#range")]
            public IList<Range> Range { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasCasedesc")]
            public IList<HasCasedesc>
                HasCasedesc { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasCaseimage")]
            public IList<HasCaseimage>
                HasCaseimage { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasCaselink")]
            public IList<HasCaselink>
                HasCaselink { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasCaseprice")]
            public IList<HasCaseprice>
                HasCaseprice { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasCpu")]
            public IList<HasCpu>
                HasCpu { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasCpudesc")]
            public IList<HasCpudesc>
                HasCpudesc { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasCpuimage")]
            public IList<HasCpuimage>
                HasCpuimage { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasCpulink")]
            public IList<HasCpulink>
                HasCpulink { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasCpuprice")]
            public IList<HasCpuprice>
                HasCpuprice { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasGpu")]
            public IList<HasGpu>
                HasGpu { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasGpudesc")]
            public IList<HasGpudesc>
                HasGpudesc { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasGpuimage")]
            public IList<HasGpuimage>
                HasGpuimage { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasGpulink")]
            public IList<HasGpulink>
                HasGpulink { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasGpuprice")]
            public IList<HasGpuprice>
                HasGpuprice { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasHdd")]
            public IList<HasHdd>
                HasHdd { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasHdddesc")]
            public IList<HasHdddesc>
                HasHdddesc { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasHddimage")]
            public IList<HasHddimage>
                HasHddimage { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasHddlink")]
            public IList<HasHddlink>
                HasHddlink { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasHddprice")]
            public IList<HasHddprice>
                HasHddprice { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasHsf")]
            public IList<HasHsf>
                HasHsf { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasHsfdesc")]
            public IList<HasHsfdesc>
                HasHsfdesc { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasHsfimage")]
            public IList<HasHsfimage>
                HasHsfimage { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasHsflink")]
            public IList<HasHsflink>
                HasHsflink { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasHsfprice")]
            public IList<HasHsfprice>
                HasHsfprice { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasId")]
            public IList<HasId>
                HasId { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasLastupdated")]
            public IList<HasLastupdated>
                HasLastupdated { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasMobo")]
            public IList<HasMobo>
                HasMobo { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasMobodesc")]
            public IList<HasMobodesc>
                HasMobodesc { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasMoboimage")]
            public IList<HasMoboimage>
                HasMoboimage { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasMobolink")]
            public IList<HasMobolink>
                HasMobolink { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasMoboprice")]
            public IList<HasMoboprice>
                HasMoboprice { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasPsu")]
            public IList<HasPsu>
                HasPsu { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasPsudesc")]
            public IList<HasPsudesc>
                HasPsudesc { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasPsuimage")]
            public IList<HasPsuimage>
                HasPsuimage { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasPsulink")]
            public IList<HasPsulink>
                HasPsulink { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasPsuprice")]
            public IList<HasPsuprice>
                HasPsuprice { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasRam")]
            public IList<HasRam>
                HasRam { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasRamdesc")]
            public IList<HasRamdesc>
                HasRamdesc { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasRamimage")]
            public IList<HasRamimage>
                HasRamimage { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasRamlink")]
            public IList<HasRamlink>
                HasRamlink { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasRamprice")]
            public IList<HasRamprice>
                HasRamprice { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasSsd")]
            public IList<HasSsd>
                HasSsd { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasSsddesc")]
            public IList<HasSsddesc>
                HasSsddesc { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasSsdimage")]
            public IList<HasSsdimage>
                HasSsdimage { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasSsdlink")]
            public IList<HasSsdlink>
                HasSsdlink { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasSsdprice")]
            public IList<HasSsdprice>
                HasSsdprice { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasTier")]
            public IList<HasTier>
                HasTier { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasTierdesc")]
            public IList<HasTierdesc>
                HasTierdesc { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasTierimage")]
            public IList<HasTierimage>
                HasTierimage { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasTotal")]
            public IList<HasTotal>
                HasTotal { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/pc2-ontology#hasUpdated")]
            public IList<HasUpdated>
                HasUpdated { get; set; }
        }
    }
}