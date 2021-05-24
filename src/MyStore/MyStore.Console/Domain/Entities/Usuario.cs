using Flunt.Notifications;
using MyStore.Core.Domain.ValueObjects;
using System.Collections.Generic;

namespace MyStore.Core.Domain.Entities
{
    public class Usuario: Notifiable<Notification>
    {
        public CPF CPF { get; private set; }
        public IList<Permissao> Permissoes { get; private set; }
        public Usuario()
        {
            AddNotifications(CPF);
            Permissoes = new List<Permissao>();
        }
        public void AddPermissao(Permissao permissao)
        {
            if (permissao is null)
                return;

            Permissoes.Add(permissao);
        }
    }
}
