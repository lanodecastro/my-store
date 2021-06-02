using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Core.Domain.Entities
{
    public class ItemPedido
    {
        public Guid Id { get; private set; }
        public Pedido Pedido { get; private set; }
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }

    }
}
