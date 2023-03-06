using QyonAdventureWorks.Domain.Repositories;
using QyonAdventureWorks.Infra.Repositories;

namespace QyonAdventureWorks.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICompetidorRepository, CompetidorRepository>();
            services.AddScoped<IHistoricoCorridaRepository, HistoricoCorridaRepository>();
            services.AddScoped<IPistaCorridaRepository, PistaCorridaRepository>();
        }

        public void Configure(WebApplication app)
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

            app.Run();
        }
    }
}