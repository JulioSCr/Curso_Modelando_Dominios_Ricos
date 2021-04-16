using System;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

/// command é como se fosse o insert
namespace PaymentContext.Domain.Commands {
    public class CreateCreditCardSubscriptionCommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string LastTransactionNumber { get; set; }
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
    }
}