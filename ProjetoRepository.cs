using Exo.WebApi.Contexts;
using Exo.WebApi.Models;

namespace Exo.WebApi.Repositories
{
    // Repository: único ponto que conversa direto com o banco de dados.
    public class ProjetoRepository
    {
        private readonly ExoContext _context;

        public ProjetoRepository(ExoContext context)
        {
            _context = context;
        }

        // SELECT * FROM Projetos
        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }

        // Extra: SELECT ... WHERE Id = @id  (devolve null se não existir)
        public Projeto BuscaPorId(int id)
        {
            return _context.Projetos.Find(id);
        }
    }
}
