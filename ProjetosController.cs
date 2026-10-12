using Exo.WebApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Exo.WebApi.Controllers
{
    // Rota base: api/projetos
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;

        // O repositório é entregue pela injeção de dependência (configurada no Program.cs).
        public ProjetosController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        // GET api/projetos  ->  200 OK + lista em JSON
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_projetoRepository.Listar());
        }

        // Extra - GET api/projetos/2  ->  200 OK + projeto, ou 404 se não existir
        [HttpGet("{id}")]
        public IActionResult BuscaPorId(int id)
        {
            var projeto = _projetoRepository.BuscaPorId(id);

            if (projeto == null)
            {
                return NotFound();
            }

            return Ok(projeto);
        }
    }
}
