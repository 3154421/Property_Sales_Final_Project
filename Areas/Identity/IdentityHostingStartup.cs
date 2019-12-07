using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Property_Sales_Final_Project.Models;

[assembly: HostingStartup(typeof(Property_Sales_Final_Project.Areas.Identity.IdentityHostingStartup))]
namespace Property_Sales_Final_Project.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Property_Sales_IdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Property_Sales_IdentityContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<Property_Sales_IdentityContext>();
            });
        }
    }
}