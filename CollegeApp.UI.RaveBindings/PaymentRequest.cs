using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp.UI.RaveBindings
{
    public class PaymentRequest
    {
        public decimal Amount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string TransactionRef { get; init; }   
        public string CustomerId { get; set; }
        public string CustomerMap { get; set; }

        public PaymentRequest()
        {
            TransactionRef = Guid.NewGuid().ToString();
        }
    }
}
