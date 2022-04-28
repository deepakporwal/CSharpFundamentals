using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LinqSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to linq samples application !");

            int[] fibonacci = { 0, 1, 1, 2, 3, 5 };
            // Scalar return value
            int numberOfElements = fibonacci.Count();
            Console.WriteLine("Count : {0}",numberOfElements);

            IEnumerable<int> distinctNumber = fibonacci.Distinct();

            foreach (var data in distinctNumber)
            {
                Console.WriteLine(data);
            }

            fibonacci.Where(x => x > 2).ToArray();

            Console.WriteLine("************** Read Xml string in Linq*********************");

            var xml = @"
                        <ingredients>
                         <ingredient name='milk' quantity='200' price='2.99' />
                         <ingredient name='sugar' quantity='100' price='4.99' />
                         <ingredient name='safron' quantity='1' price='46.77' />
                        </ingredients>";

            XElement xmlData = XElement.Parse(xml);
            XElement milk = xmlData.Descendants("ingredient").First(x => x.Attribute("name").Value == "milk");
            XAttribute priceAttribute = milk.Attribute("price");
            string priceOfMilk = priceAttribute.Value; // 2.99
            Console.WriteLine("milk {0}", priceOfMilk);

            Console.WriteLine("************** Read Xml string in Linq*********************");

            Console.ReadLine();

        }
    }
}
