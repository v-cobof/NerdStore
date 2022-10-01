using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalogo.Domain
{
    public class Produto : Entity, IAggregateRoot
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string Imagem { get; private set; }
        public int QuantidadeNoEstoque { get; private set; }
        public Guid CategoriaId { get; private set; }
        public Categoria Categoria { get; private set; }
        public Dimensoes Dimensoes { get; private set; }

        public Produto(string nome, string descricao, bool ativo, decimal valor, DateTime dataCadastro, string imagem, Guid categoriaId, Dimensoes dimensoes)
        {
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            Valor = valor;
            DataCadastro = dataCadastro;
            Imagem = imagem;
            CategoriaId = categoriaId;
            Dimensoes = dimensoes;

            Validar();            
        }

        public void Ativar() => Ativo = true;

        public void Desativar() => Ativo = false;

        public void AlterarCategoria(Categoria categoria)
        {
            Categoria = categoria;
            CategoriaId = categoria.Id;
        }

        public void AlterarDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public void DebitarEstoque(int quantidade)
        {
            quantidade = Math.Abs(quantidade);
            if (!PossuiEstoque(quantidade)) throw new DomainException("Estoque insuficiente");
            QuantidadeNoEstoque -= quantidade;
        }

        public void ReporEstoque(int quantidade)
        {
            QuantidadeNoEstoque += quantidade;
        }

        public bool PossuiEstoque(int quantidade)
        {
            return QuantidadeNoEstoque >= quantidade;
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O Nome do produto não pode ser vazio");
            Validacoes.ValidarSeVazio(Descricao, "A Descricao do produto não pode ser vazia");
            Validacoes.ValidarSeIgual(CategoriaId, Guid.Empty, "O CategoriaId do produto não pode ser vazio");
            Validacoes.ValidarSeMenorOuIgual(Valor, 0, "O Valor não pode ser menor ou igual a zero");
            Validacoes.ValidarSeVazio(Imagem, "A Imagem não pode ser vazia");
        }
    }
}