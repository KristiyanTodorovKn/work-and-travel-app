using WorkAndTravelAgency.Core.Contracts;
using WorkAndTravelAgency.Core.Services;
using WorkAndTravelAgency.Infrastructure.Data.Common;

namespace WorkAndTravelAgency.Extensions
{
    public static class WorkAndTravelServceCollection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IAgentService, AgentService>();
            services.AddScoped<IJobTypeService, JobTypeService>();

            return services;
        }
    }
}
