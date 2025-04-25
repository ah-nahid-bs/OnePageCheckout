One Page Checkout for ASP.NET Core
==================================

A modern, responsive one-page checkout solution for ASP.NET Core MVC applications.

Installation
------------

Install the package via NuGet:

```
dotnet add package OnePageCheckout.AspNetCore
```

Setup
-----

1.  **Add Services**

    Add the required services in Program.cs:

    ```
    builder.Services.AddOnePageCheckout();
    ```

2.  **Include Assets**

    Include the required assets in your _Layout.cshtml:

    ```
    <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" href="~/css/site.css" />
    <!-- At the bottom of the body -->
    <script src="~/lib/jquery/dist/jquery.min.js"></script>
    <script src="~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"></script>
    ```

3.  **Add Checkout Model**

    Add the checkout model to your project:

    ```
    public class CheckoutViewModel
    {
        public UserDetails UserDetails { get; set; }
        public ShippingDetails ShippingDetails { get; set; }
        public PaymentDetails PaymentDetails { get; set; }
    }
    ```

4.  **Use in Controller**

    Use the checkout view in your controller:

    ```
    public IActionResult Checkout()
    {
        return View("Checkout", new CheckoutViewModel());
    }
    ```

Features
--------

-   Responsive design using Bootstrap

-   Progressive form completion

-   Client-side validation

-   Customizable styling

-   Mobile-friendly interface

Customization
-------------

Customize the appearance by overriding the default styles in your CSS file:

```
.checkout-container {
    /* Your custom styles */
}
```

Building and Publishing the Package
-----------------------------------

1.  **Build the Release Version**

    ```
    dotnet build -c Release
    ```

2.  **Create the NuGet Package**

    ```
    dotnet pack -c Release
    ```

    The package will be created in the bin/Release directory.

Integration Instructions for Developers
---------------------------------------

1.  Install the package via NuGet Package Manager or .NET CLI

2.  Add the required service configuration

3.  Include the necessary view imports

4.  Implement the checkout controller

5.  Customize the styling as needed

The package includes:

-   All required views and partial views

-   CSS and JavaScript assets

-   Model classes and validation

-   Controller logic

-   Bootstrap and jQuery dependencies

License
-------

MIT License