using Flunt.Notifications;
using MyStore.Core.Domain.ValueObjects;
using System;

namespace MyStore.Core.Domain.Entities
{
    public class Perfil:Notifiable<Notification>
    {
        public Guid Id { get; private set; }
        public Descritor Descricao { get; private set; }

        public Perfil(string descricao)
        {
            Descricao = new Descritor(descricao,3,10,"Descrição","Descrição não pode ser nula");
            AddNotifications();
        }
    }
}
