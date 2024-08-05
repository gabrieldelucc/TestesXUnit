using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Test
{
    public class InventarioTeste
    {

        [Fact]
        public void TestAdicionarProduto() 
        {
        
           //Arrange 
           var inventario = new Inventario();
            inventario.AdicionarProduto("ProdutoA", 10);

            //Act 

            inventario.AdicionarProduto("ProdutoA", 5);

            //Assert 
            Assert.Equal(15, inventario.ObterQuantidadeProduto("ProdutoA")); 


        }

        [Fact]
        public void ObterProdutoInexistente()
        {
            // Arrange 
            var inventario = new Inventario();

            // Act 
            int quantidade = inventario.ObterQuantidadeProduto("ProdutoInexistente"); 

            //Assert 
            Assert.Equal( 0, quantidade);


        }

    }
}
