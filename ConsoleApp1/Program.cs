using ConsoleApp1.interfaces;
using System;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            ICustomer obj = new Customer();
            obj.Add();
            obj.GetAllCustomers();
           
            Console.WriteLine("Hello World! God is great !");



            Console.ReadLine();
        }
    }
}
