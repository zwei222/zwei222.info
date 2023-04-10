using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Fast.Components.FluentUI;
using MyWebSite;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
ConfigureServices(builder.Services);
await builder.Build().RunAsync();

static void ConfigureServices(IServiceCollection services)
{
    services.AddHttpClient();
    services.AddFluentUIComponents();
}
