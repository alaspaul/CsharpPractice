using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System.IO;
using practiceApp.CustomMiiddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<custommiddle>();
var app = builder.Build();

app.UseLoginMiddleware();

app.Run();