using ConsoleApp1.interfaces;
using System;
using Newtonsoft.Json;

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

            // inheritance example when base class method is virtual
            Employee objemp = new Employee();
            objemp.FirstName = "deepak";
            objemp.LastName = "porwal";
            string fullName = objemp.GetFullName();
            objemp.Salary = 100000;

            Console.WriteLine(JsonConvert.SerializeObject(objemp));
            Console.WriteLine(objemp.GetFullName());

            // inheritance example when base class method is abstract
            Employee2 objemp2 = new Employee2();
            objemp2.FirstName = "deepak";
            objemp2.LastName = "porwal";
            string fullName2 = objemp2.GetFullName();
            objemp2.Salary = 100000;

            Console.WriteLine(JsonConvert.SerializeObject(objemp2));
            Console.WriteLine(objemp2.GetFullName());

            Console.ReadLine();
        }
    }
}
