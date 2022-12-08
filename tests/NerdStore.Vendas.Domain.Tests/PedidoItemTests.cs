using NerdStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Domain.Tests
{
    public class PedidoItemTests
    {
        [Fact(DisplayName = "Criar novo Pedido Item com quantidade acima do permitido")]
        [Trait("Categoria", "Vendas - Pedido Item")]
        public void AdicionarItemPedido_QuantidadeDoItemAcimaDoPermitido_DeveLancarException()
        {
            // Arrange && Act && Assert
            Assert.Throws<DomainException>(() => 
                new PedidoItem(new Guid(), "Produto", Pedido.MAX_UNIDADES_ITEM + 1, 100)
            );
        }

        [Fact(DisplayName = "Criar novo Pedido Item com quantidade abaixo do permitido")]
        [Trait("Categoria", "Vendas - Pedido Item")]
        public void AdicionarItemPedido_QuantidadeDoItemAbaixoDoPermitido_DeveLancarException()
        {
            // Arrange && Act && Assert
            Assert.Throws<DomainException>(() =>
                new PedidoItem(new Guid(), "Produto", Pedido.MIN_UNIDADES_ITEM - 1, 100)
            );
        }
    }
}
