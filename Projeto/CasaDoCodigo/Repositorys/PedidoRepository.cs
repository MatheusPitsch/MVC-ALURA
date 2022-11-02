using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositorys
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ApplicationContext context) : base(context)
        {
        }
    }
}