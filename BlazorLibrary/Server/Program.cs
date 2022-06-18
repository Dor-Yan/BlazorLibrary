using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.DependencyInjection.Extensions;
using BlazorLibrary.Persistance;
using BlazorLibrary.Application;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddApplication();
builder.Services.AddPersitance(builder.Configuration);

builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Logging.ClearProviders();

var logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

builder.Logging.AddSerilog(logger);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
