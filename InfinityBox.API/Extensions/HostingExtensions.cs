﻿using EntityFrameworkCore.UnitOfWork.Extensions;
using InfinityBox.Application;
using InfinityBox.Infrastructure;
using InfinityBox.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace InfinityBox.API.Extensions
{
    public static class HostingExtensions
    {
        public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddApplicationServices();
            builder.Services.AddInfrastructureServices(builder.Configuration);
            builder.Services.AddWebApiServices();

            return builder.Build();
        }
        public static async Task<WebApplication> ConfigurePipelineAsync(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

                using var scope = app.Services.CreateScope();
                var initialiser = scope.ServiceProvider.GetRequiredService<ApplicationDbContextInitializer>();
                await initialiser.InitialiseAsync();
                await initialiser.SeedAsync();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            return app;
        }
    }
}
