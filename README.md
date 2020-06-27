# Yggdrasil
![Nuget](https://img.shields.io/nuget/v/Yggdrasil.NET)

C# async wrapper of Yggrasil - the Mojang authentication system.
## Example
```cs
var yggdrasil = new YggdrasilService();
var auth = await yggdrasil.AuthenticateAsync(new AuthenticatePayload
{
    Agent = Agent.Minecraft,
    RequestUser = true,
    Username = "user@email.com",
    Password = "password"
});

if (auth.Success)
{
    // Do something
    Console.WriteLine(auth.Response.AccessToken);
}
else
{
    Console.WriteLine(auth.ErrorResponse.Message);
}
```
