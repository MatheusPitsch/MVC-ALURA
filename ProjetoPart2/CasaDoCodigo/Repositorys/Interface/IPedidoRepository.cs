using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositorys
{
    public interface IPedidoRepository
    {
        Pedido GetPedido();
        void AddItem(string Codigo);
    }
}