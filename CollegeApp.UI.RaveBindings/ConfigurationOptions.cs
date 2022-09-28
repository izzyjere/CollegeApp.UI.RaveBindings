﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp.UI.RaveBindings
{
    public class ConfigurationOptions
    {
        public string PublicKey { get; set; }
        public string LogoUrl { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public List<PaymentOptions> PaymentMethods { get; private set; }
        public ConfigurationOptions(ConfigurationOptions options)
        {
            LogoUrl = options.LogoUrl;
            Title = options.Title;
            Description = options.Description;
            PublicKey = options.PublicKey;
            PaymentMethods = new List<PaymentOptions>();
        }
        public void AddPaymentOptions(PaymentOptions options)
        {
            PaymentMethods.Add(options);
        }  
    }
}
