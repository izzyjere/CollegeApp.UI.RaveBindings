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
        private readonly Options options;
        public JavaScriptInterop(IJSRuntime jsRuntime, Options options)
        {
            this.options = options;
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./_content/CollegeApp.UI.RaveBindings/CollegeApp.RaveBindings.min.js").AsTask());
        }

        public async ValueTask<object> MakePayment(PaymentRequest request, object caller)
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<object>("makePayment",options.PublicKey,options.PaymentOptions.ToArray(),request.Currency,request.Amount,request.TransactionRef,request.Customer,request.CustomerId,request.CustomerMac,request.Phone,request.Email,options.Title,options.Description,options.LogoUrl,DotNetObjectReference.Create(caller));             
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