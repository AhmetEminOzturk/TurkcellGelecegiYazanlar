using Microsoft.EntityFrameworkCore;
using SurveyApp.Infrastructure.Data;

namespace SurveyApp.API.IoCExtensions
{
    public static class IoCExtensions
    {
        public static IServiceCollection AddInjections(this IServiceCollection services, string connectionString)
        {

            //IoC
            services.AddDbContext<SurveyDbContext>(opt => opt.UseSqlServer(connectionString));

            return services;
        }
    }
}
