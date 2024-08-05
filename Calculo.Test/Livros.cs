using System.Collections.Generic;
using Xunit;

namespace Proj.Test
{
    public class LivrosTests
    {
        private Livros biblioteca;

        public LivrosTests()
        {
            biblioteca = new Livros();
        }

        [Fact]
        public void AdicionarLivro()
        {
            // Arrange
            string livro = "The Silver Eyes";

            // Act
            biblioteca.AdicionarLivro(livro);

            // Assert
            List<string> livros = biblioteca.ListarLivros();
            Assert.Contains(livro, livros);
        }
    }
}
