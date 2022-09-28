# CollegeApp.UI.RaveBindings

Easily integrate flutterwave in blazor with no JavaScript needed.
## Example usage
```csharp
using CollegeApp.UI.RaveBindings;

// registering service;
builder.Services.AddServerSideBlazor();
builder.Services.AddPaymentServices(options =>
{
    options.AddPaymentOptions(PaymentOptions.MobileMoneyZambia); // can add multiple payment methods
    options.Title = "Title to show on the checkout modal";
    options.Description = "Description to show on the modal";
    options.PublicKey = "Your-Public Key Here";
});

```
```razor
@using CollegeApp.UI.RaveBindings
<CheckoutButton Model="@request" 
				IconCss="oi oi-credit-card" 
				OnPaymentCancelled="FailedToPay" 
				OnPaymentComplete="ProcessPayment">
				Pay Now
</CheckoutButton>
@code {
    PaymentRequest request = new PaymentRequest
        {

            Amount = 10,
            Currency = "ZMW",
            Email = "example@email.com",
            Phone ="0960000000",
            Customer = "Wisdom Jere",
            CustomerId = "1102",
            CustomerMac = "JustTesting",

    };
    void ProcessPayment(PaymentResponse response)
    {
           //Validate payment and save to db
    }
    void FailedToPay(string respose)
    {
        //Do with analytics incase payment was cancelled
    }
}
```
## Adding it to your project with nuget

**Package Manager**

```sh
Install-Package CollegeApp.UI.RaveBindings -Version 1.8.3 
```

**.NET CLI**

```sh
dotnet add package CollegeApp.UI.RaveBindings --version 1.8.3
```
**PackageReference**

```sh
<PackageReference Include="CollegeApp.UI.RaveBindings" Version="1.0.0" />
```
