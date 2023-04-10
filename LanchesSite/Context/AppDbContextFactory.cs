using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LanchesSite.Context;

public class AppDbContextFactory //: IDesignTimeDbContextFactory<AppDbContext>
{
    //public AppDbContext CreateDbContext(string[] args)
    //{
    //    IConfigurationRoot configuration = new ConfigurationBuilder()
    //            .SetBasePath(Directory.GetCurrentDirectory())
    //            .AddJsonFile("appsettings.json")
    //            .Build();

    //    // Criando o DbContextOptionsBuilder manualmente
    //    var builder = new DbContextOptionsBuilder<AppDbContext>();
    //    // cria a connection string. 
    //    // requer a connectionstring no appsettings.json
    //    var connectionString = configuration.GetConnectionString("ConnectionString");
    //    builder.UseSqlServer(connectionString);

    //    // Cria o contexto
    //    return new AppDbContext(builder.Options);
    //}
}
