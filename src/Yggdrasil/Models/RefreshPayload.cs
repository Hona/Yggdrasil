using Newtonsoft.Json;

namespace Yggdrasil.Models
{
    public class RefreshPayload
    {
        [JsonProperty("accessToken")] public string AccessToken { get; set; }

        [JsonProperty("clientToken")] public string ClientToken { get; set; }

        /// <summary>
        ///     Optional, sending will result in an error
        /// </summary>
        [JsonProperty("selectedProfile")]
        public SlimProfile SelectedProfile { get; set; }

        /// <summary>
        ///     Setting this to true adds the user object to the response
        /// </summary>
        [JsonProperty("requestUser")]
        public bool RequestUser { get; set; }
    }
}