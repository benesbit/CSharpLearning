using System;
using System.Text.Json.Serialization;

namespace rest_tutorial
{
        public class Repository
    {
        [JsonPropertyName("name")]
        public string name { get; set; }
    }
}