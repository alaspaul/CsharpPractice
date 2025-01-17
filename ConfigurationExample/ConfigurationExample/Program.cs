using ConfigurationExample;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.Configure<WeatherApiOptions>
    (builder.Configuration.GetSection("weatherAPI"));
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();



app.Run();
