
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using LimsFrontEnd.Services;

namespace LimsFrontEnd.Utils;
public class AuthStateProvider : AuthenticationStateProvider
{


    private readonly ISessionService _sessionStorage;
    private readonly HttpClient _http;
    private readonly ILogger<AuthStateProvider> _logger;

    public AuthStateProvider(ISessionService sessionStorage, HttpClient http, ILogger<AuthStateProvider> logger)
    {
        _sessionStorage = sessionStorage;
        _http = http;
        _logger = logger;
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        try
        {
            var token = await _sessionStorage.GetItemAsync("authToken");

            if (string.IsNullOrWhiteSpace(token))
            {
                return AnonymousUser();
            }

            var claims = ParseJwtToken(token);
            var identity = new ClaimsIdentity(claims, "jwt","name","role");
            var user = new ClaimsPrincipal(identity);

            return new AuthenticationState(user);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to get authentication state");
            return AnonymousUser();
        }
    }

    private AuthenticationState AnonymousUser()
    {
        return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
    }

    private IEnumerable<Claim> ParseJwtToken(string jwt)
    {
        var handler = new JwtSecurityTokenHandler();
        var token = handler.ReadJwtToken(jwt);
        return token.Claims;
    }

    public async Task MarkUserAsAuthenticated(string token)
    {
        await _sessionStorage.SetItemAsync("authToken", token);
        var authState = await GetAuthenticationStateAsync();
        NotifyAuthenticationStateChanged(Task.FromResult(authState));
    }

    public async Task MarkUserAsLoggedOut()
    {
        await _sessionStorage.RemoveItemAsync("authToken");
        NotifyAuthenticationStateChanged(Task.FromResult(AnonymousUser()));
    }
}