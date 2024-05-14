using MetaMonkeysBillingSystem.App;
using MetaMonkeysBillingSystem.App.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using SqliteWasmHelper;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSqliteWasmDbContextFactory<MMStoreDBContext>(options => options.UseSqlite("Data Source=MM_Store_DB.db"));
await builder.Build().RunAsync();
