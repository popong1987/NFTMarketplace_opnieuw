using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NFTMarketplace_webapplicaties_opnieuw.Data;

[assembly: HostingStartup(typeof(NFTMarketplace_webapplicaties_opnieuw.Areas.Identity.IdentityHostingStartup))]
namespace NFTMarketplace_webapplicaties_opnieuw.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}