using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 
            var json = "{\"id\": 1,\"name\": \"Test\",\"price\": 100.0}";           

            var desObj = JsonSerializer.Deserialize<ObjClass>(json);
            if(desObj != null ){desObj.name = "Waleed Siddique";}
            var newObj = JsonSerializer.Serialize<ObjClass>(desObj);
            Console.WriteLine(newObj);
            #endregion

            #region
            List<int> numList = new List<int>() { 1, 2, 2, 3, 3, 3 };
            dynamic list = CreateDictionary(numList);
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
            #endregion


            List<PaymentMethod> paymentMethods = new List<PaymentMethod>
            {
                new CreditCardPayment(),
                new PayPalPayment(),
                new BankTransferPayment()
            };

            decimal[] paymentAmounts = { 100, 200, 300 };

            for (int i = 0; i < paymentMethods.Count; i++)
            {
                paymentMethods[i].ProcessPayment(paymentAmounts[i]);
            }

            Console.ReadKey();

        }
        public class ObjClass
        {
            public int id { get; set; }
            public string name { get; set; }
            public decimal price { get; set; }
        }
        private static dynamic CreateDictionary(List<int> list)
        {
            var dictionary = list.GroupBy(num => num).ToDictionary(x => x.Key,x => x.Count());
            return dictionary;
        }
    }
}
