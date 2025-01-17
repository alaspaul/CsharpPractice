using Services;
using ServiceContracts;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
/*builder.Services.Add(new ServiceDescriptor(
    typeof(ICitiesService),
    typeof(CitiesService),
    ServiceLifetime.Scoped
    ));*/

builder.Services.AddTransient<ICitiesService, CitiesService>();
var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();
app.MapControllers();


app.Run();
