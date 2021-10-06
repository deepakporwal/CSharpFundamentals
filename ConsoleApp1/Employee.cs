using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee : Person
    {
        public decimal Salary { get; set; }

        public override string GetFullName()
        {
            string originalValue = base.GetFullName();
            return LastName + " "+ FirstName;
        }
    }

    public class Employee2 : Person2
    {
        public decimal Salary { get; set; }

        public override string GetFullName()
        {
            return LastName + " " + FirstName;
        }
    }
}
