using FluentValidation.AspNetCore;
using FluentValidation_2.Controllers;
using FluentValidation_2.Models;
using FluentValidation_2.Models.FluentValidationExtension;
using FluentValidation_2.Models.Validators;
using ServiceLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddControllersWithViews().AddFluentValidation(x =>
//{
//    x.RegisterValidatorsFromAssemblyContaining<HomeController>();
//    x.DisableDataAnnotationsValidation = true;
//    x.ValidatorOptions.LanguageManager.Culture = new System.Globalization.CultureInfo("tr");
//});

builder.Services.AddFluetAsExtension();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=CreateProduct}/{id?}");

app.Run();
