using Newtonsoft.Json;

namespace Yggdrasil.Models
{
    public abstract class TokensPayload
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        /// <summary>
        ///     Optional, if used, it should be the same as was used to obtain the AccessToken
        /// </summary>
        [JsonProperty("clientToken")]
        public string ClientToken { get; set; }
    }
}