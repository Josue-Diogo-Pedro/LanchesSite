using LanchesSite.Context;
using LanchesSite.Repositories;
using LanchesSite.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesSite;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        //services.AddControllers();
        services.AddMvc();
        services.AddControllersWithViews();

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ConnectionString"))
        );

        //services.AddDbContext<NewDBContext>();

        services.AddScoped<ILancheRepository, LancheRepository>();
        services.AddScoped<ICategoriaRepository, CategoriaRepository>();


    }

    public void Configure(WebApplication app, IWebHostEnvironment ev)
    {
        if (!ev.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("Home/Error");
            app.UseHsts();
        }
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
