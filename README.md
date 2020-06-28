# Yggdrasil
![Nuget](https://img.shields.io/nuget/v/Yggdrasil.NET)

C# async wrapper of Yggrasil - the Mojang authentication system.
## Usage
### Authentication
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

### Validation & Refreshing
```cs
var authValid = await yggdrasil.ValidateAsync(new ValidatePayload
{
    // Invalid/old token will return invalid
    AccessToken = auth.Response.AccessToken,
    ClientToken = auth.Response.ClientToken
});

if (authValid.Success && 
    authValid.Response == ValidateResponse.Valid)
{
    // We are authenticated
    Console.WriteLine("Valid token");
}
else
{
    // Invalid token, need to refresh
    var refreshAuth = await yggdrasil.RefreshAsync(new RefreshPayload
    {
        AccessToken = auth.Response.AccessToken,
        ClientToken = auth.Response.ClientToken
    });

    if (refreshAuth.Success)
    {
        // Refreshed token successfully
        Console.WriteLine(refreshAuth.Response.AccessToken);
    }
}
```

### Signout (Invalidation using credentials)
```cs
var signout = await yggdrasil.SignoutAsync(new SignoutPayload
{
    Username = "user@name.com",
    Password = "password"
});

if (signout.Success && 
    signout.Response == StandardResponse.Success)
{
    Console.WriteLine("All access tokens invalidated.");
}
```

### Invalidation (by tokens)
```cs
var invalidate = await yggdrasil.InvalidateAsync(new InvalidatePayload
{
    AccessToken = auth.Response.AccessToken,
    ClientToken = auth.Response.ClientToken
});

if (invalidate.Success &&
    invalidate.Response == StandardResponse.Success)
{
    Console.WriteLine("All access tokens invalidated by tokens.");
}
```
