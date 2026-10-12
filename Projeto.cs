namespace Exo.WebApi.Models
{
    // Entidade Projeto: cada propriedade corresponde a uma coluna da tabela Projetos.
    public class Projeto
    {
        public int Id { get; set; }
        public string NomeDoProjeto { get; set; }
        public string Area { get; set; }
        public bool Status { get; set; }
    }
}
