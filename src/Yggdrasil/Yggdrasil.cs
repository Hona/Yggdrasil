using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Yggdrasil.Models;

namespace Yggdrasil
{
    public class Yggdrasil
    {
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://authserver.mojang.com")
        };

        public Yggdrasil()
        {
            _httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");
        }

        private async Task<YggdrasilResponse<T>> PostAsync<T, T2>(string endpoint, T2 payload)
        {
            var response =
                await _httpClient.PostAsync(endpoint, new StringContent(JsonConvert.SerializeObject(payload)));
            object stringValue = await response.Content.ReadAsStringAsync();

            var output = new YggdrasilResponse<T>();
            if (response.IsSuccessStatusCode)
            {
                output.ErrorResponse = null;
                output.Success = true;

                // Deserializes and sets the response object
                // If T is a string, don't deserialize
                if (typeof(T) == typeof(string))
                    output.Response = (T) stringValue;
                else if (typeof(T).IsEnum)
                    // Sets the enum responses to 1 (success/valid), can't do this cleanly since T may also be a class
                    output.Response = (T) Enum.Parse(typeof(T), "1");
            }
            else
            {
                output.Success = false;

                // Request failed, response is now the error
                output.ErrorResponse = JsonConvert.DeserializeObject<ErrorResponse>((string) stringValue);

                // Setting the default value on failure also sets the Response enums to 0 (failure)
                output.Response = default;
            }

            return output;
        }

        public async Task<YggdrasilResponse<AuthenticateResponse>> AuthenticateAsync(AuthenticatePayload payload)
            => await PostAsync<AuthenticateResponse, AuthenticatePayload>("/authenticate", payload);

        public async Task<YggdrasilResponse<RefreshResponse>> RefreshAsync(RefreshPayload payload)
            => await PostAsync<RefreshResponse, RefreshPayload>("/refresh", payload);

        public async Task<YggdrasilResponse<ValidateResponse>> ValidateAsync(ValidatePayload payload)
            => await PostAsync<ValidateResponse, ValidatePayload>("/validate", payload);

        public async Task<YggdrasilResponse<StandardResponse>> SignoutAsync(SignoutPayload payload)
            => await PostAsync<StandardResponse, SignoutPayload>("/signout", payload);

        public async Task<YggdrasilResponse<StandardResponse>> InvalidateAsync(InvalidatePayload payload)
            => await PostAsync<StandardResponse, InvalidatePayload>("/invalidate", payload);
    }
}