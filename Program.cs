// Program.cs
using BlazingPizza.Data;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

// Registrar el servicio
builder.Services.AddSingleton<PizzaService>();

await builder.Build().RunAsync();
