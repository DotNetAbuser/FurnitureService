using Client.Infrastructure.Extensions;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddManagers();
builder.Services.AddClientServices();

await builder.Build().RunAsync();
