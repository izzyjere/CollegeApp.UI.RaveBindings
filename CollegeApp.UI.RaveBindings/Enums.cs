using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp.UI.RaveBindings
{
    public enum PaymentType
    {
        All,
        MobileMoney,
        Card,
        BankTransfer,
        VirtualCard
    }
    public enum Country
    {
        [Description("KE")]
        Kenya,
        [Description("UG")]
        Uganda,
        [Description("GH")]
        Ghana,
        [Description("NG")]
        Nigeria,
        [Description("NG")]
        Rwanda,
        [Description("NG")]
        Zambia

    }
}
