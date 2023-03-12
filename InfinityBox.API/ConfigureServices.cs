using InfinityBox.API.Filters;
using InfinityBox.Infrastructure.Persistence;

namespace InfinityBox.API
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddWebApiServices(this IServiceCollection services)
        {

            services.AddHealthChecks().AddDbContextCheck<ApplicationDbContext>();

            #region Controllers
            services.AddControllers(options =>
            {
                options.Filters.Add<ApiExceptionFilterAttribute>();
            });
            #endregion

            #region Swagger
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            #endregion

            return services;
        }
    }
}
