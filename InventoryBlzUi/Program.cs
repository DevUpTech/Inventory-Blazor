// Code generated by DevUp technologies, 11/12/2023 17:28:59
using InventoryBlzUi;
using InventoryBlzUi.APIClient;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

string baseUri= "https://localhost:7097/";

builder.Services.AddHttpClient<ProductAPIClient>(options =>
		{
	options.BaseAddress = new Uri(baseUri);
		});



// builder.Services.AddHttpClient<ProductAPIClient>(options =>
// {
    // options.BaseAddress = new Uri("https://localhost:7097/api");
// });

await builder.Build().RunAsync();
