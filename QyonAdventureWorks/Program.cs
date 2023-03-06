using Microsoft.EntityFrameworkCore;
using QyonAdventureWorks.Api;
using QyonAdventureWorks.Infra.Config;

namespace QyonAdventureWorks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<ContextBase>(
                    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"), b => b.MigrationsAssembly("QyonAdventureWorks.Api"))
                );

            var startup = new Startup(builder.Configuration);
            startup.ConfigureServices(builder.Services);
            var app = builder.Build();
            startup.Configure(app);
        }
    }
}