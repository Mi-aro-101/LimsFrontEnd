using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.SessionStorage;
using LimsFrontEnd;
using MudBlazor.Services;
using LimsFrontEnd.Utils;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using Microsoft.AspNetCore.Components.Authorization;
using LimsFrontEnd.Services;


// TODO Do not forget to change branch before continuing development
// TODO Push this

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices(); // MudBlazor Services

builder.Services.AddHttpClient("AuthorizedClient", client =>
    {
        client.BaseAddress = new Uri("http://localhost:5077/api/");
    }).AddHttpMessageHandler<AuthorizationHandler>();

builder.Services.AddScoped(sp => 
    sp.GetRequiredService<IHttpClientFactory>().CreateClient("AuthorizedClient"));

// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5077/api/") }.AddHttpMessageHandler<AuthorizationHandler>());

//Authorization
builder.Services.AddOptions();
builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
builder.Services.AddScoped<ISessionService, SessionService>();
builder.Services.AddAuthorizationCore();

builder.Services.AddBlazoredSessionStorage(); //service for session storage
builder.Services.AddTransient<AuthorizationHandler>();

await builder.Build().RunAsync();
