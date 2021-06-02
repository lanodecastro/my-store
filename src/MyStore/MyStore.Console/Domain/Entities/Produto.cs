using MyStore.Core.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Core.Domain.Entities
{
    public class Produto:IEntity
    {
        public Guid Id { get; private set; }
        public Descritor Nome { get; private set; }
        public decimal PrecoUnitario { get; private set; }
        public int Estoque { get; private set; }

    }
    
}
