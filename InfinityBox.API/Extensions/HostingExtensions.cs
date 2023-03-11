using InfinityBox.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace InfinityBox.API.Extensions
{
    public static class HostingExtensions
    {
        public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
        {

            #region Controllers
            builder.Services.AddControllers();
            #endregion

            #region Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            #endregion

            #region DbContext
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
                if (env == "Development")
                {
                    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
                }
                else
                {
                    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
                }
            });
            #endregion

            return builder.Build();
        }
        public static WebApplication ConfigurePipeline(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            return app;
        }
    }
}
