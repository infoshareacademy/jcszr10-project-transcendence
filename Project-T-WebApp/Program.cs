
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project_Transcendence.BuisnessLogic.Services;
using Project_Transcendence_Database.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
builder.Services.AddTransient<IPlayerService, PlayerService>();
builder.Services.AddTransient<IActionService, ActionService>();
builder.Services.AddTransient<IDamageCalculatorService, DamageCalculatorService>();

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; 
})
    .AddEntityFrameworkStores<ApplicationDbContext>();

//builder.Services.AddScoped<UserManager<ApplicationUser>>();

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


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
