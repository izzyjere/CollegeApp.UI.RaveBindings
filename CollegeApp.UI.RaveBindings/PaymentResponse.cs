using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp.UI.RaveBindings
{
    public class PaymentResponse
    {
        public string Amount { get; set; }
        public string Currency { get; set; }
        public Customer Customer { get; set; }
        [JsonProperty("flw_ref")]
        public string FWReference { get; set; }
        public string Status { get; set; }
        [JsonProperty("tx_ref")]
        public string TransactionReference { get; set; }
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }

}
