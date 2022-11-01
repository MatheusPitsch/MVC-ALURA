﻿using CasaDoCodigo.Models;
using System.Collections.Generic;

namespace CasaDoCodigo
{
    public class Repository : IRepository
    {
        private readonly ApplicationContext context;

        public Repository(ApplicationContext context)
        {
            this.context = context;
        }

        public void SaveProdutos(List<Livro> livros)
        {
            foreach (var livro in livros)
            {
                context.Set<Produto>().Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
            }
            context.SaveChanges();
        }
    }
    public class Livro
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
