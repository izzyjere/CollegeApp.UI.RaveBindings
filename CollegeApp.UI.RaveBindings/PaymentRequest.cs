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
        public string Customer { get; set; }       
        public string Email { get; set; }        
        public string Phone { get; set; }
        public string TransactionRef { get=>_tranref;  }
        string _tranref;
        public string CustomerId { get; set; }
        public string CustomerMac { get; set; }
        public string Currency { get; set; }      
        
        public PaymentRequest()
        {
           _tranref = Guid.NewGuid().ToString();
        }
    }
}
