using Newtonsoft.Json;

namespace Yggdrasil.Models
{
    public class Property
    {
        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("value")] public string Value { get; set; }
    }
}