using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using ThingsWeNeed.DataLogic.Repos;

namespace ThingsWeNeed.DataLogic
{
    public class DataLogicConfiguration
    {   
        public IConfiguration Configuration { get; }

        public DataLogicConfiguration(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ThingsWeNeedContext>( opt => opt.UseSqlServer(Configuration.GetConnectionString("ThingsWeNeedConnection")));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IThingRepo, ThingRepo>();
        }
    }
}
