using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// first approach make base class method as virtual
    /// </summary>
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
        public virtual string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }

    /// 2nd approach make class as abstract and delcare a abstract method So it can be override in derived class
    public abstract class Person2
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract string GetFullName();
    }
}
