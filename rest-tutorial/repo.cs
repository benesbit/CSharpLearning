using System;

namespace rest_tutorial
{
        public class Repository
    {
        [JsonPropertyName("name")]
        public string name { get; set; }
    }
}