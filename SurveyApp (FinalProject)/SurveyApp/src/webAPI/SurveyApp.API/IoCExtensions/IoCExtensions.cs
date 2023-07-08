using Microsoft.EntityFrameworkCore;
using SurveyApp.Infrastructure.Data;
using SurveyApp.Infrastructure.Repositories;
using SurveyApp.Services;
using SurveyApp.Services.Mappings;

namespace SurveyApp.API.IoCExtensions
{
    public static class IoCExtensions
    {
        public static IServiceCollection AddInjections(this IServiceCollection services, string connectionString)
        {

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, EFUserRepository>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IQuestionRepository, EFQuestionRepository>();
            services.AddScoped<IOptionService, OptionService>();
            services.AddScoped<IOptionRepository, EFOptionRepository>();
            services.AddScoped<IPollService, PollService>();
            services.AddScoped<IPollRepository, EFPollRepository>();

            services.AddAutoMapper(typeof(MapProfile));
            //IoC
            services.AddDbContext<SurveyDbContext>(opt => opt.UseSqlServer(connectionString));

            return services;
        }
    }
}
