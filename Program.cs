using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using S_TCHAD.Controllers;
using S_TCHAD.Data;
using S_TCHAD.Data.Service;
using S_TCHAD.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
builder.Services.AddScoped<IIBAYATSERVICE, IBAYATSERVICE>();
builder.Services.AddScoped<IACCESSORIESERVICE,ACCESSORIESERVICE>();
builder.Services.AddScoped<IBacksservice, Backsservice>();
builder.Services.AddScoped<IBeautyProductService, BeautyProductService>();
builder.Services.AddScoped<IGiftsService, GiftsService>();
builder.Services.AddScoped<IHairCreamService, HairCreamService>();
builder.Services.AddScoped<IHomeAccessoriesService, HomeAccessoriesService>();
builder.Services.AddScoped<ITIRAHSERVICE, TIRAHSERVICE>();
builder.Services.AddScoped<IUnderWearService, UnderWearService>();
builder.Services.AddScoped<IWomenShooeseService, WomenShooeseService>();
//Authentication and Authorization
builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
});

builder.Services.AddControllersWithViews();

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
//app Authentication and Authorization
app.UseAuthentication();
app.UseAuthorization();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
AppDbSeed.Seed(app);
AppDbSeed.SeedUsersAndRolesAsync(app).Wait();
app.Run();
