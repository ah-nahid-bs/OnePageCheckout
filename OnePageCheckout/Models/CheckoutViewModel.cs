using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnePageCheckout.Models;

public class CheckoutViewModel
{
    // User Details
    public UserDetails UserDetails { get; set; }
    
    // Shipping Details
    public ShippingDetails ShippingDetails { get; set; }
    
    // Payment Details
    public PaymentDetails PaymentDetails { get; set; }
    
    // Order Summary
    public OrderSummary OrderSummary { get; set; }
    
    // Additional Note
    public string AdditionalNote { get; set; }
}

public class UserDetails
{
    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required]
    [Phone]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; }
}

public class ShippingDetails
{
    [Required]
    [Display(Name = "Address Line 1")]
    public string AddressLine1 { get; set; }

    [Display(Name = "Address Line 2")]
    public string AddressLine2 { get; set; }

    [Required]
    public string City { get; set; }

    [Required]
    public string State { get; set; }

    [Required]
    [Display(Name = "Postal Code")]
    public string PostalCode { get; set; }

    [Required]
    public string Country { get; set; }
}

public class PaymentDetails
{
    [Required]
    [Display(Name = "Payment Method")]
    public string PaymentMethod { get; set; }  // Credit Card, PayPal, etc.

    [Required]
    [CreditCard]
    [Display(Name = "Card Number")]
    public string CardNumber { get; set; }

    [Required]
    [Display(Name = "Card Holder Name")]
    public string CardHolderName { get; set; }

    [Required]
    [Display(Name = "Expiry Date")]
    public string ExpiryDate { get; set; }

    [Required]
    [Display(Name = "CVV")]
    public string CVV { get; set; }
}

public class OrderSummary
{
    public List<OrderItem> Items { get; set; }
    public decimal Subtotal { get; set; }
    public decimal ShippingCost { get; set; }
    public decimal Tax { get; set; }
    public decimal Total { get; set; }
}

public class OrderItem
{
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Total { get; set; }
}