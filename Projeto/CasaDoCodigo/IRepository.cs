using System.Collections.Generic;

namespace CasaDoCodigo
{
    public interface IRepository
    {
        void SaveProdutos(List<Livro> livros);
    }
}