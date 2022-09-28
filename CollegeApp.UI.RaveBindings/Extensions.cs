using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.JSInterop;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp.UI.RaveBindings
{    
    public static class Extensions
    {  
        public static IServiceCollection AddPaymentServices(this IServiceCollection services, Action<ConfigurationOptions> configuration)
        {
            if(configuration==null) throw new ArgumentNullException(nameof(configuration));
            var options = new ConfigurationOptions();
            configuration(options);
            services.TryAddScoped(builder => new PaymentService(builder.GetRequiredService<IJSRuntime>(),options,builder.GetRequiredService<NavigationManager>()));           
            return services;
        }
        public static string ToDescriptionString(this Enum val)
        {
            var attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0
                ? attributes[0].Description
                : val.ToString();
        }
    }
}
