using ENEMScore.Client.Services;
using ENEMScore.Client.Services.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IDarkModeService, DarkModeService>();
builder.Services.AddMudServices();


await builder.Build().RunAsync();
