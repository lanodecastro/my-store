using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Core.Domain.Entities
{
    public class Pedido:IEntity
    {
        public Guid Id { get; private set; }
        public Cliente Cliente { get; private set; }
        public IList<ItemPedido> Produtos { get; private set; }
    }
}
