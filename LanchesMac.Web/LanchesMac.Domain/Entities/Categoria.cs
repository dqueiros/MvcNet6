
namespace LanchesMac.Domain.Entities
{
    public sealed class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descriçao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
