using System.Collections.Generic;
using Newtonsoft.Json;

namespace Yggdrasil.Models
{
    public class AuthenticateResponse
    {
        [JsonProperty("accessToken")] public string AccessToken { get; set; }

        [JsonProperty("clientToken")] public string ClientToken { get; set; }

        [JsonProperty("availableProfiles")] public List<Profile> AvailableProfiles { get; set; }

        [JsonProperty("selectedProfile")] public Profile SelectedProfile { get; set; }

        [JsonProperty("user")] public User User { get; set; }
    }
}