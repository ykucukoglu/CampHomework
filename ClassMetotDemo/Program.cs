using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Yasemen",
                Lastame = "Küçükoğlu",
                City = "Istanbul"
            };
            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "İbrahim",
                Lastame = "Delbe",
                City = "Ankara"
            };
            Customer customer3 = new Customer()
            {
                Id = 3,
                Name = "Ali",
                Lastame = "Veli",
                City = "Bursa"
            };

      

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            customerManager.List();

            customerManager.Delete(customer2);
            customerManager.List();



        }
    }
}
