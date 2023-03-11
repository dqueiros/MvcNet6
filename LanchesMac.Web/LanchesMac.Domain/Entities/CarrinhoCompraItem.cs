
namespace LanchesMac.Domain.Entities
{
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemId { get; set; }
        public int LancheId { get; set; }
        public int Quantidade { get; set; }
        public Guid CarrinhoCompraId { get; set; }
        public Lanche Lanche { get; set; }
    }
}
