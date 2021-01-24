using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        ArrayList customers = new ArrayList();
        public void Delete(Customer customer)
        {
            customers.Remove(customer);
            Console.WriteLine("Customer Id Number " + customer.Id + " has been deleted.");
        }
        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
        public void List()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Id: " + customer.Id + " ,Name: " + customer.Name + " , Lastname: " + customer.Lastame+" , City: "+customer.City);
            }
        }
    }
}
