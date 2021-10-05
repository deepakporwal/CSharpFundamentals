﻿using ConsoleApp1.interfaces;
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

            SimpleCalss simplobj = new SimpleCalss();
            Console.WriteLine(simplobj.Sum(1.23, 2.34));
            Console.WriteLine(simplobj.Sum(1, 2));
            Console.WriteLine(simplobj.Sum(1, 2,3));
            Console.ReadLine();
        }
    }
}
