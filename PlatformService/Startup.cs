using Microsoft.EntityFrameworkCore;
using PlatformService.Data;

public class Startup
{
    public IConfiguration Configuration { get; }
    public Startup(IConfiguration configuration)
    {
        this.Configuration = configuration;
    }

    // This method gets called by the runtime. Use this method to add serices to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(opt =>
        opt.UseInMemoryDatabase("InMem")
        );

        services.AddScoped<IPlatformRepo, PlatformRepo>();
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(WebApplication app, IApplicationBuilder  app1, IWebHostEnvironment env)
    {
        PrepDb.PrepPopulation(app1);

    }
}