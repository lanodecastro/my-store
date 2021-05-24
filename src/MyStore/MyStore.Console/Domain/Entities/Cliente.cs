using Flunt.Notifications;
using Flunt.Validations;
using MyStore.Core.Domain.ValueObjects;
using System;

namespace MyStore.Core.Domain.Entities
{
    public class Cliente:Notifiable<Notification>
    {
        public Guid Id { get; private set; }
        public CPF CPF { get; private set; }
        public Descritor Nome { get; private set; }
        public Descritor Sobrenome { get; private set; }
        public DateTime? DataNascimento { get; private set; }
        public DateTime CriadoEm { get; private set; }
        public DateTime AlteradoEm { get; private set; }

        public Cliente(string nome,string sobrenome,DateTime? dataNascimento)
        {
            AddNotifications(ObterContratoValidacao(dataNascimento,nome));

            if (!IsValid) return;

            Id = Guid.NewGuid();
            CriadoEm = DateTime.Now;
        }
        public void Atualizar(string cpf,string nome,DateTime? dataNascimento)
        {
            AddNotifications(ObterContratoValidacao(dataNascimento,nome));          

            if (!IsValid) return;

            AlteradoEm = DateTime.Now;
        }
        private Contract<Notification> ObterContratoValidacao(DateTime? dataNascimento,string nome)
        {
            Nome = new Descritor(nome,5,8,"Nome","Nome não pode ser nulo");
            return new Contract<Notification>()
              .Requires()
              .IsLowerOrEqualsThan(dataNascimento.Value.Year, DateTime.Now.Year - 1, "Data Nascimento", "Data Nascimento não pode ser maior que 2020")
              .Join(Nome,Sobrenome,CPF);
        }

       
    }
}
