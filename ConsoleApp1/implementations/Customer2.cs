using ConsoleApp1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Customer : ICustomer
    {
        public void GetAllCustomers() 
        {
            Console.WriteLine("all customers listed");
        }
    }
}
