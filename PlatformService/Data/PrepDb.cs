using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb 
    {
        public static void PrepPopulation(IApplicationBuilder app,bool isProd)
        {
                using(var serviceScope = app.ApplicationServices.CreateScope())
                {
                    seedData(serviceScope.ServiceProvider.GetService<AppDbContext>()!,isProd);

                }
                

        }

        private static void seedData(AppDbContext context, bool isProd)
        {
            if(isProd) 
            {
                Console.WriteLine("-->Attempting to apply migrations...");
                try 
                {
                    context.Database.Migrate();

                } catch (Exception ex)
                {
                     Console.WriteLine($"--> Could not run migrations: {ex.Message}");

                }

            }
            if(!context.Platforms.Any()) 
            {
                Console.WriteLine("-->Seeding data...");

                context.Platforms.AddRange(
                    new Platform () {Name="Dot Net", Publisher="Microsoft", Cost="free"},
                    new Platform () {Name="SQL Server Express", Publisher="Microsoft", Cost="free"},
                     new Platform () {Name="Kubernetes", Publisher="Cloud Native Computing Foundation", Cost="free"}
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("-->We already have data");
            }
        }

    }
}