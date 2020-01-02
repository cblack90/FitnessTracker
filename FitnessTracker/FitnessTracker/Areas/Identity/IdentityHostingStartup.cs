using System;
using FitnessTracker.Areas.Identity.Data;
using FitnessTracker.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FitnessTracker.Areas.Identity.IdentityHostingStartup))]
namespace FitnessTracker.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FitnessTrackerContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FitnessTrackerContextConnection")));

                //services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<FitnessTrackerContext>();
            });
        }
    }
}