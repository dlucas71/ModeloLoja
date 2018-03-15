using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Core.Entities;
using Loja.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Loja.Web.Pages.Produtos
{
    public class IndexModel : PageModel
    {
        private readonly IProdutoRepository produtoRepository;

        public IndexModel(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public string Titulo { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }

        public void OnGet()
        {
            Titulo = "Loja";
            Produtos = produtoRepository.GetAll();
        }
    }
}