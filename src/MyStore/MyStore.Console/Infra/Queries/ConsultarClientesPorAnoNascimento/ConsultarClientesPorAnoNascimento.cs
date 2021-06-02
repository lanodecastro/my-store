using MyStore.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Core.Infra.Queries
{
    public class ConsultarClientesPorAnoNascimento:ICommand
    {
        public int AnoNascimento { get; set; }
        public object Result { get; set; }

    }
}
