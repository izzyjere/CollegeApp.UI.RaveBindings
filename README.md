# CollegeApp.UI.RaveBindings

Easily integrate flutterwave in blazor with no JavaScript needed.
## Example usage
```csharp
using CollegeApp.UI.RaveBindings;

// registering service;
builder.Services.AddServerSideBlazor();
builder.Services.AddPaymentServices(o =>
{
    options.AddPaymentOptions(PaymentOptions.MobileMoneyZambia);
    options.Title = "Title to show on the checkout modal";
    options.Description = "Description to show on the modal";
    options.PublicKey = "Your-Public Key Here";
});

```
## Adding it to your project with nuget

**Package Manager**

```sh
Install-Package CollegeApp.UI.RaveBindings -Version 1.0.0 
```

**.NET CLI**

```sh
dotnet add package CollegeApp.UI.RaveBindings --version 1.0.0
```
**PackageReference**

```sh
<PackageReference Include="CollegeApp.UI.RaveBindings" Version="1.0.0" />
```
