using System;
using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();

            AddNotifications(name, document, email);
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            /// Diferença entre excessão e validação:
            /// Uma excessão é algo que não esperamos que vá acontecer
            /// Por exemplo o banco estar fora, não era pro banco estar fora
            /// Já uma validação é algo que você espera que aconteça

            /// A implicação de colocar um throw new Excepion
            /// Interrompe a thread e toda vez que não é tratada ele armazena no log do windows
            /// Isso pode travar o servidor, pois pode ter muita exception enchendo o log do windows

            // Se já tiver uma assinatura ativa, cancela


            // Cancela todas as outras assinaturas, e coloca esta como principal
            foreach (var sub in Subscriptions)
            {
                sub.Inactivate();
            }

            _subscriptions.Add(subscription);
        }
    }
}
