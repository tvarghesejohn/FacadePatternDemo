using FacadePatternDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePatternDemo.Facades
{
    internal class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");
            Product product = new Product();
            product.GetProductDetails();
            PaymentService payment = new PaymentService();
            payment.MakePayment();
            InvoiceService invoice = new InvoiceService();
            invoice.Sendinvoice();
            Console.WriteLine("Order Placed Successfully");
        }
    }
}
