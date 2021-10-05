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

            // create a anynymous type 
            var data = new { Id = 1, Name = "Deepak Porwal", IsActice = true };
            Console.WriteLine("the value of Id {0} and Name is {1}",data.Id,data.Name);

            Console.ReadLine();
        }
    }
}
