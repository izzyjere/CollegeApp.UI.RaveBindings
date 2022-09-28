using System.ComponentModel;

namespace CollegeApp.UI.RaveBindings
{
    public enum PaymentOptions
    {
        [Description("mobilemoneyzambia")]
        MobileMoneyZambia, 
        [Description("mobilemoneyzambia")]
        MobileMoneyTanzania,
        [Description("mobilemoneyghana")]
        MobileMoneyGhana,
        [Description("mobilemoneyuganda")]
        MobileMoneyUganda,
        [Description("mobilemoneyghana")]
        MobileMoneyRwanda,
        [Description("mobilemoneyrwanda")]
        MobileMoneyCameroon,
        [Description("mobilemoneyghana")]
        MobileMoneyIvoryCoast,
        [Description("mpesa")]
        MpesaKenya ,
        [Description("card")]
        Card,
        [Description("ussd")]
        USSD
              
    }
}
