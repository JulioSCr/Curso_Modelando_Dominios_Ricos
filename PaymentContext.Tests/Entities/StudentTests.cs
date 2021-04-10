using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace paymentcontext.tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var subscription = new Subscription(null);
            var student = new Student("Julio", "Cruz", "123546789", "julio@julio.com");
            // student.Subscriptions.Add(subscription);
            student.AddSubscription(subscription);
        }
    }
}
