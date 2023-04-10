using LanchesSite.Context;
using LanchesSite.Models;
using LanchesSite.Repositories.Interfaces;

namespace LanchesSite.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
