using Demo.Data;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using CollegeApp.UI.RaveBindings;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddPaymentServices(options =>
{
    options.AddPaymentOptions(PaymentOptions.MobileMoneyZambia); // can add multiple payment methods
    options.Title = "Title to show on the checkout modal";
    options.LogoLocation = "assets/img/logo.png";
    options.Description = "Description to show on the modal";
    options.PublicKey = "FLWPUBK_TEST-803633b41c973f55bc42ac4fc753171f-X";
});
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
