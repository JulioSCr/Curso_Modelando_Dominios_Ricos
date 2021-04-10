using System;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firsName, string lastName)
        {
            FirsName = firsName;
            LastName = lastName;

            if (firsName.Length == 0)
                throw new Exception("Nome inválido");
        }

        public string FirsName { get; private set; }
        public string LastName { get; private set; }
    }
}