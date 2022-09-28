using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace CollegeApp.UI.RaveBindings
{
    // This class provides an example of how JavaScript functionality can be wrapped
    // in a .NET class for easy consumption. The associated JavaScript module is
    // loaded on demand when first needed.
    //
    // This class can be registered as scoped DI service and then injected into Blazor
    // components for use.

    public class JavaScriptInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;
        private readonly ConfigurationOptions options;
        private readonly NavigationManager navigationManager;
        public JavaScriptInterop(IJSRuntime jsRuntime, ConfigurationOptions options, NavigationManager navigationManager)
        {
            this.options = options;
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./_content/CollegeApp.UI.RaveBindings/CollegeApp.RaveBindings.min.js").AsTask());
            this.navigationManager=navigationManager;
        }

        public async ValueTask<object> MakePayment(PaymentRequest request, object caller)
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<object>("makePayment",options.PublicKey,options.PaymentMethods.Select(o=>o.ToDescriptionString()).ToArray(),request.Currency,request.Amount,request.TransactionRef,request.Customer,request.CustomerId,request.CustomerMac,request.Phone,request.Email,options.Title,options.Description,$"{navigationManager.BaseUri}/{options.LogoLocation}",DotNetObjectReference.Create(caller));             
        }


        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}