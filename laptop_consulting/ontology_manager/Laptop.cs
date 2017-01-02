using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ontology_manager
{
    namespace Laptop
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

        public class HasDesc
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasTitle
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasCategory
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasCreatedAt
        {
            [JsonProperty("@value")]
            public DateTime Value { get; set; }
        }

        public class HasCurrency
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasImage
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasMisc
        {
            [JsonProperty("@id")]
            public string Id { get; set; }
        }

        public class HasName
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasObjectId
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasOrder
        {
            [JsonProperty("@type")]
            public string Type { get; set; }

            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasReview
        {
            [JsonProperty("@id")]
            public string Id { get; set; }
        }

        public class HasType
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasUpdatedAt
        {
            [JsonProperty("@value")]
            public DateTime Value { get; set; }
        }

        public class HasLink
        {
            [JsonProperty("@value")]
            public string Value { get; set; }
        }

        public class HasRating
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

        public class Object
        {
            [JsonProperty("@id")]
            public string Id { get; set; }

            [JsonProperty("@type")]
            public IList<string> Type { get; set; }

            [JsonProperty("http://www.w3.org/2002/07/owl#unionOf")]
            public IList<UnionOf> UnionOf { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/laptop-ontology#hasDesc")]
            public IList<HasDesc> HasDesc { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/laptop-ontology#hasTitle")]
            public IList<HasTitle> HasTitle { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/laptop-ontology#hasCategory")]
            public IList<HasCategory> HasCategory { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/laptop-ontology#hasCreatedAt")]
            public IList<HasCreatedAt> HasCreatedAt { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/laptop-ontology#hasCurrency")]
            public IList<HasCurrency> HasCurrency { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/laptop-ontology#hasImage")]
            public IList<HasImage> HasImage { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/laptop-ontology#hasMisc")]
            public IList<HasMisc> HasMisc { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/laptop-ontology#hasName")]
            public IList<HasName> HasName { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/laptop-ontology#hasObjectId")]
            public IList<HasObjectId> HasObjectId { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/laptop-ontology#hasOrder")]
            public IList<HasOrder> HasOrder { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/laptop-ontology#hasReview")]
            public IList<HasReview> HasReview { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/laptop-ontology#hasType")]
            public IList<HasType> HasType { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/laptop-ontology#hasUpdatedAt")]
            public IList<HasUpdatedAt> HasUpdatedAt { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/laptop-ontology#hasLink")]
            public IList<HasLink> HasLink { get; set; }

            [JsonProperty("http://www.semanticweb.org/anon/ontologies/2016/12/laptop-ontology#hasRating")]
            public IList<HasRating> HasRating { get; set; }

            [JsonProperty("http://www.w3.org/2000/01/rdf-schema#domain")]
            public IList<Domain> Domain { get; set; }

            [JsonProperty("http://www.w3.org/2000/01/rdf-schema#range")]
            public IList<Range> Range { get; set; }
        }
    }
}