using Model.Entities;
using Model.Repositories.Interfaces;
using Model.Services.Interfaces;


namespace Model.Services.MetaService
{

    public class AutorService : IMetaService
    {
        private readonly IAutorRepository _metaRepository;

        public AutorService(IAutorRepository repository)
        {
            _metaRepository = repository;
        }

        public Task AddMeta(Autor meta)
        {
            return _metaRepository.AddAutor(meta);
        }

        public async Task<Autor?> GetMetaById(int id)
        {
            return await _metaRepository.GetAutorById(id);
        }
        public async Task<List<Autor>> GetAllMeta()
        {
            return (await _metaRepository.GetAllAutores()).ToList();
        }

        public async Task SaveChangesAsync()
        {
            await _metaRepository.SaveChangesAsync();
        }

    }
}
