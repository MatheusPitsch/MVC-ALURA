using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositorys
{
    public class CadastroRepository : BaseRepository<Cadastro> , ICadastroRepository
    {
        public CadastroRepository(ApplicationContext context) : base(context)
        {
        }
    }
}