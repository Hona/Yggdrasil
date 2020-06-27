using System;
using Newtonsoft.Json;

namespace Yggdrasil.Models
{
    public class User : SlimUser
    {
        /// <summary>
        ///     Possibly hashed value for unmigrated accounts
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        ///     Regular username for unmigrated accounts, email for migrated accounts
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        ///     IP address with the last byte censored
        /// </summary>
        [JsonProperty("registerIp")]
        public string RegisterIp { get; set; }

        [JsonProperty("migratedFrom")] public string MigratedFrom { get; set; }

        [JsonProperty("migratedAt")] public long MigratedAt { get; set; }

        [JsonIgnore] public DateTimeOffset MigratedAtDTO => DateTimeOffset.FromUnixTimeMilliseconds(MigratedAt);

        [JsonProperty("registeredAt")] public long RegisteredAt { get; set; }

        [JsonIgnore] public DateTimeOffset RegisteredAtDTO => DateTimeOffset.FromUnixTimeMilliseconds(RegisteredAt);

        [JsonProperty("passwordChangedAt")] public long PasswordChangedAt { get; set; }

        [JsonIgnore]
        public DateTimeOffset PasswordChangedAtDTO => DateTimeOffset.FromUnixTimeMilliseconds(PasswordChangedAt);

        [JsonProperty("dateOfBirth")] public long DateOfBirth { get; set; }

        [JsonIgnore] public DateTimeOffset DateOfBirthDTO => DateTimeOffset.FromUnixTimeMilliseconds(DateOfBirth);

        [JsonProperty("suspended")] public bool Suspended { get; set; }

        [JsonProperty("blocked")] public bool Blocked { get; set; }

        [JsonProperty("secured")] public bool Secured { get; set; }

        [JsonProperty("migrated")] public bool Migrated { get; set; }

        [JsonProperty("emailVerified")] public bool EmailVerified { get; set; }

        [JsonProperty("legacyUser")] public bool LegacyUser { get; set; }

        [JsonProperty("verifiedByParent")] public bool VerifiedByParent { get; set; }
    }
}