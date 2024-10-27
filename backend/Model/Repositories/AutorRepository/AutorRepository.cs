using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Entities;
using Model.Repositories.Interfaces;

namespace Model.Repositories.MetaRepository
{
    public class AutorRepository : IAutorRepository
    {
        public readonly PolisContext _context;

        public AutorRepository(PolisContext context)
        {
            _context = context;
        }

        public async Task AddAutor(Autor meta)
        {
            await _context.AddAsync(meta);
        }

        public async Task<Autor?> GetAutorById(int id)
        {
            return await _context.Meta.FindAsync(id);
        }

        public async Task<IEnumerable<Autor>> GetAllAutores()
        {
            return await _context.Meta.ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
