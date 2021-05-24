using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Core.Domain.Entities
{
    public class Permissao
    {
        public Usuario Usuario { get; private set; }
        public Perfil Perfil { get; private set; }

    }
}
