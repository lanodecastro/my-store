using MyStore.Core.Domain;
using MyStore.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Core.Commands.CadastrCliente
{
    public class CadastrarClienteHandler : ICommandHandler<CadastrarCliente>
    {
        private readonly IRepository<Cliente> _clienteRepository;
        public CadastrarClienteHandler(IRepository<Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Execute(CadastrarCliente command)
        {
            var cliente = new Cliente(command.Nome, command.Sobrenome, command.DataNascimento);

            _clienteRepository.Save(cliente);

        }
    }
}
