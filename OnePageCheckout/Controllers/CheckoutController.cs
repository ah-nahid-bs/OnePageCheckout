using Microsoft.AspNetCore.Mvc;
using OnePageCheckout.Models;
using System.Collections.Generic;

namespace OnePageCheckout.Controllers;

public class CheckoutController : Controller
{
    public IActionResult Index()
    {
        var model = new CheckoutViewModel
        {
            UserDetails = new UserDetails(),
            ShippingDetails = new ShippingDetails(),
            PaymentDetails = new PaymentDetails(),
            OrderSummary = GetOrderSummary() // You'll need to implement this based on your cart system
        };
        return View(model);
    }

    [HttpPost]
    public IActionResult ProcessCheckout(CheckoutViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View("Index", model);
        }

        // Process the order
        // Add your order processing logic here

        return RedirectToAction("Confirmation");
    }

    private OrderSummary GetOrderSummary()
    {
        // Implement this method to get the order summary from your shopping cart
        return new OrderSummary
        {
            Items = new List<OrderItem>(),
            Subtotal = 0,
            ShippingCost = 0,
            Tax = 0,
            Total = 0
        };
    }
}