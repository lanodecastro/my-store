using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Core.Domain.ValueObjects
{
    public class CPF : Notifiable<Notification>
    {
        public string Value { get; private set; }
        public CPF(string cpf)
        {
            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNullOrEmpty(cpf, "CPF", "")
                .IsLowerOrEqualsThan(cpf, 14, "CPF", "")
                .IsGreaterOrEqualsThan(cpf, 14, "CPF", "")
                .IsTrue(DvCpfValido(cpf), "", "")
                );

            if (!IsValid) return;

            Value = cpf;
        }
        private bool DvCpfValido(string cpf)
        {
            return true;
        }

    }
}
