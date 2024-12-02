using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PaymentMethod
    {        
        public virtual void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Base Class Method {amount}");
        }
    }
    public class CreditCardPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Credit Card Payment Method {amount}");
        }
    }
    public class PayPalPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"PayPal Payment Method {amount}");
        }
    }
    public class BankTransferPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Bank Transfer Payment Method {amount}");
        }
    }

}
