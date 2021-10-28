using ConsoleApp1.interfaces;
using System;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

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

            SimpleClass simplobj = new SimpleClass();
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

            ArrayList myArr = new ArrayList();
            myArr.Add(1);
            myArr.Add(2);
            myArr.Add("deepak");

            // generic list is strongly typed and flexible , perfomance faster than array list
            List<int> genList = new List<int>(); 
            genList.Add(10);

            // TPL = Task parallel library --- utilizes the CPU processor properly.
            Task t = new Task(Method1);
            t.Start();

            Task t1 = new Task(Method2);
            t1.Start();

            Console.ReadLine();
        }

        static void Method1() 
        {
        
        }

        static void Method2() 
        {
        
        }
    }
}
