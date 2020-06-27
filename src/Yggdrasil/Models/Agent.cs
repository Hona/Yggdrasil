using Newtonsoft.Json;

namespace Yggdrasil.NET.Models
{
    public class Agent
    {
        /// <summary>
        ///     The name of the game
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Typically 1 as set by the vanilla client
        /// </summary>
        [JsonProperty("version")]
        public int Version { get; set; } = 1;

        public static Agent Minecraft => new Agent
        {
            Name = "Minecraft",
            Version = 1
        };
    }
}