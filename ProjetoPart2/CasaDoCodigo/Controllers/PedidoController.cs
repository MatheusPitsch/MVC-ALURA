using CasaDoCodigo.Models;
using CasaDoCodigo.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoController(IProdutoRepository produtoRepository, IPedidoRepository pedidoRepository)
        {
            this._produtoRepository = produtoRepository;
            this._pedidoRepository = pedidoRepository;
        }

        public IActionResult Carrossel()
        {
            return View(_produtoRepository.GetProdutos());
        }

        public IActionResult Carrinho(string Codigo)
        {
            if (!string.IsNullOrEmpty(Codigo))
            {
                _pedidoRepository.AddItem(Codigo);
            }

            var pedido = _pedidoRepository.GetPedido();
            return View(pedido.Itens);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            Pedido pedido = _pedidoRepository.GetPedido();

            return View(pedido);
        }

        [HttpPost]
        public void UpdateQuantidade(int itemPedidoId,int quantidade)
        {

        }
    }
}