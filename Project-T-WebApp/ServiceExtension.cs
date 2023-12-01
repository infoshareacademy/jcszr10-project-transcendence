using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Project_Transcendence_Database.DataAccess;

namespace Project_T_WebApp
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connString = configuration["ConnectionStrings:Default"];

            services.AddDbContext<ApplicationDbContext>(o =>
            {
                o.UseSqlServer(connString);
            });

            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 4;
                options.Password.RequireDigit = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
            })
        .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }
    }
}
