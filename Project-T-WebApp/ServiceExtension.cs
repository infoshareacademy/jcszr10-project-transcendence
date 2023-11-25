using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project_Transcendence_Database.DataAccess;
using System.Data;

namespace Project_T_WebApp
{
    public static class ServiceExtension
    {
        //public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        //{
        //    var connString = configuration["ConnectionStrings:Default"];

        //    services.AddDbContext<ApplicationDBContext>(o =>
        //    {
        //        o.UseSqlServer(connString);
        //    });

        //    services.AddIdentity<IdentityUser, IdentityRole>()
        //        .AddEntityFrameworkStores<ApplicationDBContext>();

        //    services.Configure<IdentityOptions>(options =>
        //    {
        //        options.Password.RequiredLength = 4;
        //        options.Password.RequireDigit = true;
        //        options.Password.RequireUppercase = true;
        //        options.Password.RequireLowercase = true;
        //        options.Password.RequireNonAlphanumeric = true;
        //    });
        //    services.AddControllersWithViews();

        //    return services;
        //}
    }
}
