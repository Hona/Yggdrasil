using Newtonsoft.Json;

namespace Yggdrasil.Models
{
    public class ErrorResponse
    {
        /// <summary>
        ///     Short description of the error
        /// </summary>
        [JsonProperty("error")]
        public ErrorType Error { get; set; }

        [JsonProperty("cause")] public string Cause { get; set; }

        /// <summary>
        ///     Longer description of the error, can be shown to the user
        /// </summary>
        [JsonProperty("errorMessage")]
        public string Message { get; set; }
    }
}