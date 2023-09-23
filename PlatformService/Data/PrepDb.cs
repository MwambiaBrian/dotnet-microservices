using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb 
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
                using(var serviceScope = app.ApplicationServices.CreateScope())
                {
                    seedData(serviceScope.ServiceProvider.GetService<AppDbContext>());

                }
                

        }

        private static void seedData(AppDbContext context)
        {
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