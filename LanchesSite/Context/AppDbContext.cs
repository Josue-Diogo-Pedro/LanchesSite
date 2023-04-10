using LanchesSite.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesSite.Context;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{ }

	public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Lanche> Lanches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-Q89RIRM\\SQLEXPRESS; initial catalog=DbLanches; integrated security=true; trust server certificate=true;");
    }
}
