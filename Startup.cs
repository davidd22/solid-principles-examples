using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace OopPrinciple
{
    public class Startup
    {

        IConfigurationRoot Configuration { get; }
        public List<string> TrackingDomains;
        public List<int> LinkIds;
        public Startup()
        {
            var builder = new ConfigurationBuilder()

                 .AddJsonFile("appsettings.json", false, true)
                 .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = "localhost";
                options.InstanceName = "LOCAL";
            });
        }
        public void Configure(string env)
        {

        }
    }
}
