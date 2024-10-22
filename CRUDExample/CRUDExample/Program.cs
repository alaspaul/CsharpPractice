using Services;
using ServiceContracts;
using Microsoft.EntityFrameworkCore;
using Entities;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<ICountriesService, CountriesService>();
builder.Services.AddSingleton<IPersonsService, PersonsService>();

builder.Services.AddDbContext<PersonsDbContext>
    (options =>
    {
        options.UseSqlServer(
            builder.Configuration
            ["ConnectionStrings:DefaultConnection"]);

        //Data Source=(localdb)\ProjectModels;Initial Catalog=PersonsDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
    });

var app = builder.Build();


app.UseRouting();
app.MapControllers();
app.UseStaticFiles();




app.Run();
