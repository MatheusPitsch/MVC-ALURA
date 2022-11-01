using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CasaDoCodigo
{
    class DataService : IDataService
    {
        private readonly ApplicationContext context;
        private readonly IRepository repository;

        public DataService(ApplicationContext context, IRepository repository)
        {
            this.context = context;
            this.repository = repository;
        }

        public void InicializaDB()
        {
            context.Database.Migrate();

            List<Livro> livros = GetLivros();

            repository.SaveProdutos(livros);
        }

        private static List<Livro> GetLivros()
        {
            var readJsonProfile = File.ReadAllText("livros.json");
            var livros = JsonConvert.DeserializeObject<List<Livro>>(readJsonProfile);
            return livros;
        }        
    }    
}