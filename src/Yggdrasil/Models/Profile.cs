using System;
using Newtonsoft.Json;

namespace Yggdrasil.NET.Models
{
    public class Profile : SlimProfile
    {
        [JsonProperty("agent")] public string Agent { get; set; }

        /// <summary>
        ///     Stored as a hex string
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        ///     Milliseconds since the unix epoch
        /// </summary>
        [JsonProperty("createdAt")]
        public long CreatedAt { get; set; }

        [JsonIgnore] public DateTimeOffset CreatedAtDTO => DateTimeOffset.FromUnixTimeMilliseconds(CreatedAt);

        [JsonProperty("legacyProfile")] public bool Legacy { get; set; }

        [JsonProperty("suspended")] public bool Suspended { get; set; }

        [JsonProperty("paid")] public bool Paid { get; set; }

        [JsonProperty("migrated")] public bool Migrated { get; set; }

        /// <summary>
        ///     Redundant to the Legacy property, only present when true
        /// </summary>
        [JsonProperty("legacy")]
        public bool RedundantLegacy
        {
            set => Legacy = value;
        }
    }
}