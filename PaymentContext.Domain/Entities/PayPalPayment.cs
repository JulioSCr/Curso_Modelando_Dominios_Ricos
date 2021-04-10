using System;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(
            string transactionCode,
            DateTime paidDate,
            DateTime expiredDate,
            decimal total,
            decimal totalPaid,
            string payer,
            string document,
            string address,
            string email) : base (
                paidDate,
                expiredDate,
                total,
                totalPaid,
                payer,
                document,
                address,
                email
            )
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }
}