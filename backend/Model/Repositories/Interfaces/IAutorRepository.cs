using Model.Entities;

namespace Model.Repositories.Interfaces
{
    public interface IAutorRepository
    {
        Task<IEnumerable<Autor>> GetAllAutores();
        Task<Autor?> GetAutorById(int id);
        Task SaveChangesAsync();
        Task AddAutor(Autor meta);
    }
}
