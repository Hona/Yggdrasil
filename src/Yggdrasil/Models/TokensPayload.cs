namespace Yggdrasil.Models
{
    public abstract class TokensPayload
    {
        public string AccessToken { get; set; }

        /// <summary>
        ///     Optional, if used, it should be the same as was used to obtain the AccessToken
        /// </summary>
        public string ClientToken { get; set; }
    }
}