using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp.UI.RaveBindings
{
    public class Options
    {           
        public string PublicKey { get; set; }
        public string LogoUrl { get; set; } 
        public string Description { get; set; }
        public string Title { get; set; }
        public List<string> PaymentOptions { get; set; }
    }
}
