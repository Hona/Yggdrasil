using Newtonsoft.Json;

namespace Yggdrasil.Models
{
    public class RefreshResponse
    {
        [JsonProperty("accessToken")] public string AccessToken { get; set; }

        [JsonProperty("clientToken")] public string ClientToken { get; set; }

        [JsonProperty("selectedProfile")] public SlimProfile SelectedProfile { get; set; }

        [JsonProperty("user")] public SlimUser User { get; set; }
    }
}