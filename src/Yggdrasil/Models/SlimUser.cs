using System.Collections.Generic;
using Newtonsoft.Json;

namespace Yggdrasil.Models
{
    public class SlimUser
    {
        /// <summary>
        ///     Hex string
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")] public List<Property> Properties { get; set; }
    }
}