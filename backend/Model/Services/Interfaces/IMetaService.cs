using Model.Entities;

namespace Model.Services.Interfaces
{
    public interface IMetaService
    {
        public Task AddMeta(Autor meta);
        public Task<Autor?> GetMetaById(int id);
        public Task SaveChangesAsync();
        public Task<List<Autor>> GetAllMeta();
    }
}
