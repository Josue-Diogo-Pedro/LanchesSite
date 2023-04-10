using LanchesSite.Context;
using LanchesSite.Models;
using LanchesSite.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesSite.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => 
            _context.Lanches.Include(categoria => categoria.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => 
            _context.Lanches.Where(preferido => preferido.IsLanchePreferido).Include(categoria => categoria.Categoria);

        public Lanche GetLancheById(int id) => 
            _context.Lanches.FirstOrDefault(lancheId => lancheId.LancheId == id);
    }
}
