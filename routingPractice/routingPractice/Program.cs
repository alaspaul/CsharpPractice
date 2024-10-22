using routingPractice.CustomConstraints;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRouting(options =>
{
    options.ConstraintMap.Add("months", typeof(MonthsCustomConstraint));
});
var app = builder.Build();



app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("files/{fileName:}.{extensionName}", async (context) =>
    {
        string? routeFileName = Convert.ToString(context.Request.RouteValues["fileName"]);
        await context.Response.WriteAsync($"fileName = {routeFileName}");
    });

    endpoints.MapPost("sales-report/{year:int:min(1900)}/{month:months}", async (context) =>
    {
        int year = Convert.ToInt32(context.Request.RouteValues["year"]);
        string? month = Convert.ToString(context.Request.RouteValues["month"]);
        await context.Response.WriteAsync($"year = {year} / month = {month}");
    });
});

app.Run(async context =>
{
    await context.Response.WriteAsync($"request received at{context.Request.Path}");
});

app.Run();
