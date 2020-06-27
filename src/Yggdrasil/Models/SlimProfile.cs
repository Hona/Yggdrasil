using Newtonsoft.Json;

namespace Yggdrasil.NET.Models
{
    public class SlimProfile
    {
        /// <summary>
        ///     Stored as a hex string
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        ///     The players name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}