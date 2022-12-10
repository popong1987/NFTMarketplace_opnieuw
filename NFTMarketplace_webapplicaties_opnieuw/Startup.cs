using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NFTMarketplace_webapplicaties_opnieuw.Areas.Identity.Data;
using NFTMarketplace_webapplicaties_opnieuw.Data;
using NFTMarketplace_webapplicaties_opnieuw.Data.Repositories;
using NFTMarketplace_webapplicaties_opnieuw.Data.UnitOfWork;
using NFTMarketplace_webapplicaties_opnieuw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFTMarketplace_webapplicaties_opnieuw
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<NFTMarketplaceContext>(options => options.UseSqlServer(Configuration.GetConnectionString("LocalDBConnection")));
            services.AddDefaultIdentity<Gebruiker>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<NFTMarketplaceContext>();
            services.AddRazorPages();
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireUppercase = true;
            });
            services.AddScoped<IGenericRepository<Product>, GenericRepository<Product>>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            CreateRoles(serviceProvider).Wait();
        }

        private async Task CreateRoles(IServiceProvider serviceProvider)
        {
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            NFTMarketplaceContext context = serviceProvider.GetRequiredService<NFTMarketplaceContext>();

            IdentityResult result;

            bool rolecheck = await roleManager.RoleExistsAsync("user");
            if (!rolecheck)
                result = await roleManager.CreateAsync(new IdentityRole("user"));

            rolecheck = await roleManager.RoleExistsAsync("admin");
            if (!rolecheck)
                result = await roleManager.CreateAsync(new IdentityRole("admin"));

            context.SaveChanges();
        }
    }
}
