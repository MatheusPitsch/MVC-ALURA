using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositorys
{
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext context) : base(context)
        {
        }
    }
}