using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Student { 
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public string Address { get; set; }
    }
}