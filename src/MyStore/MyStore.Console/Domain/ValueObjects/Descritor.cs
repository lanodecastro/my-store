using Flunt.Notifications;
using Flunt.Validations;

namespace MyStore.Core.Domain.ValueObjects
{
    public class Descritor : Notifiable<Notification>
    {
        public string Value { get; private set; }
        public Descritor(string descricao,int min,int max,string prop,string msg)
        {
            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNullOrEmpty(descricao, prop, msg)
                .IsBetween(descricao.Length,min,max,prop,"O tamanho para o campo é inválido")
                );

            if (!IsValid) return;

            Value = descricao;
        }       

    }
}
