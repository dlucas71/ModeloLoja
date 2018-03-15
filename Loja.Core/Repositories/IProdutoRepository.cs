using Loja.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Core.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();

        Produto GetById(int id);
    }
}
