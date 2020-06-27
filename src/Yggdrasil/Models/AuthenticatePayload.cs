using Newtonsoft.Json;

namespace Yggdrasil.Models
{
    public class AuthenticatePayload
    {
        /// <summary>
        ///     Use the Agent.Minecraft for Minecraft
        /// </summary>
        [JsonProperty("agent")]
        public Agent Agent { get; set; }

        /// <summary>
        ///     Use email address, or for unmigrated accounts the username
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        ///     Raw password
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        ///     Optional
        /// </summary>
        [JsonProperty("clientToken")]
        public string ClientToken { get; set; }

        /// <summary>
        ///     Setting this to true adds the user object to the response
        /// </summary>
        [JsonProperty("requestUser")]
        public bool RequestUser { get; set; }
    }
}