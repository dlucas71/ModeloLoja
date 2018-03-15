using Loja.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.Core.Repositories
{
    public class MockProdutoRepository: IProdutoRepository
    {
        private List<Produto> _produtos;

        public MockProdutoRepository()
        {
            if (_produtos == null)
            {
                InicializaProdutos();
            }
        }

        private void InicializaProdutos()
        {
            _produtos = new List<Produto>
                {
                    new Produto {Id = 1, Nome = "Leite Condensado Camponesa", Valor = 12.95M, Descricao = "O melhor e mais gostoso leite", DescricaoCompleta = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", ImagemUrl = "/img/LeiteCondesado350x263.png", Destaque = true, ThumbUrl = "/img/LeiteCondesado350x263.png"},
                    new Produto {Id = 2, Nome = "Ketchup Heinz", Valor = 18.95M, Descricao = "O melhor e mais gostoso ketchup", DescricaoCompleta = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", ImagemUrl = "/img/KetchupHeins347x250.png", Destaque = false, ThumbUrl = "/img/KetchupHeins347x250.png"},
                    new Produto {Id = 3, Nome = "Nutren Leite em Pó", Valor = 18.95M, Descricao = "O melhor e mais gostoso leite em pó", DescricaoCompleta = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", ImagemUrl = "/img/Nutren535x338.png", Destaque = false, ThumbUrl = "/img/Nutren535x338.png"},
                    new Produto {Id = 4, Nome = "Pão de Mel", Valor = 15.95M, Descricao = "Um doce de pão", DescricaoCompleta = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", ImagemUrl = "/img/PaoDeMel477x244.png", Destaque = false, ThumbUrl = "/img/PaoDeMel477x244.png"}
                };
        }

        public IEnumerable<Produto> GetAll()
        {
            return _produtos;
        }

        public Produto GetById(int id)
        {
            return _produtos.FirstOrDefault(p => p.Id == id);
        }
    }
}
