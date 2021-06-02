using AutoMapper;
using MyStore.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Core.Infra.Queries
{
    public class ConsultarClientesPorAnoNascimentoHandler : ICommandHandler<ConsultarClientesPorAnoNascimento>
    {
        private readonly DefaultDbContext _defaultDbContext;
        private readonly IMapper _mapper;

        public ConsultarClientesPorAnoNascimentoHandler(DefaultDbContext defaultDbContext, IMapper mapper)
        {
            _defaultDbContext = defaultDbContext;
            _mapper = mapper;
        }

        public void Execute(ConsultarClientesPorAnoNascimento command)
        {
           var query= _defaultDbContext.ClinteDbSet
                .Where(x => x.DataNascimento.Value.Year == command.AnoNascimento);

            query.Select(x => new ConsultarClientesPorAnoNascimentoResponse()
            {
                Nome = x.Nome.Value
            });

            command.Result = query;

        }
    }
}
