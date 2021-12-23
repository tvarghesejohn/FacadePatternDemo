using FacadePatternDemo.Facades;
using System;

namespace FacadePatternDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.PlaceOrder();
            Console.Read();
        }
    }
}
