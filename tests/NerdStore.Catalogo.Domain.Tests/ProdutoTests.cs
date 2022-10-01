using NerdStore.Core;
using Xunit;

namespace NerdStore.Catalogo.Domain.Tests
{
    public class ProdutoTests
    {
        [Fact]
        public void Produto_Validar_ValidacoesDevemRetornarExceptions()
        {
            var ex = Assert.Throws<DomainException>(() =>
                new Produto(string.Empty, "Descricao", false, 100, DateTime.Now, "Imagem", Guid.NewGuid(), new Dimensoes(1, 1, 1))
            );
            Assert.Equal("O Nome do produto n�o pode ser vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto("Nome", string.Empty, false, 100, DateTime.Now, "Imagem", Guid.NewGuid(), new Dimensoes(1, 1, 1))
            );
            Assert.Equal("A Descricao do produto n�o pode ser vazia", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto("Nome", "Descricao", false, 0, DateTime.Now, "Imagem", Guid.NewGuid(), new Dimensoes(1, 1, 1))
            );
            Assert.Equal("O Valor n�o pode ser menor ou igual a zero", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto("Nome", "Descricao", false, 1000, DateTime.Now, string.Empty, Guid.NewGuid(), new Dimensoes(1, 1, 1))
            );
            Assert.Equal("A Imagem n�o pode ser vazia", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto("Nome", "Descricao", false, 1000, DateTime.Now, "Imagem", Guid.Empty, new Dimensoes(1, 1, 1))
            );
            Assert.Equal("O CategoriaId do produto n�o pode ser vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Dimensoes(0, 1, 1)
            );
            Assert.Equal("Altura n�o pode ser menor ou igual a zero", ex.Message);
        }
    }
}