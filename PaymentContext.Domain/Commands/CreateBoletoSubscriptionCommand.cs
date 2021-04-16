using System;
using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Commands;

/// command é como se fosse o insert
namespace PaymentContext.Domain.Commands {
    public class CreateBoletoSubscriptionCommand : Notifiable, ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string BarCode { get; set; }
        public string BoletoNumber { get; set; }
        public string PaymentNumber { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Payer { get; set; }
        public Document PayerDocument { get; set; }
        public EDocumentType PayerDocumentType { get; set; }
        public Email PayerEmail { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neiggbothood { get; set; }
        public string City { get; set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }

        /// O Fail Fast Validations, se chegou e as informações estão inválidas, já volta
        /// nem chega no domínio.
        /// isso reduz as requents no banco e desafoga o servidor d+
        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
                .HasMinLen(LastName, 3, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres")
                .HasMaxLen(FirstName, 40, "Name.FirsName", "Nome deve conter até 40 caracteres")
            );
        }
    }
}