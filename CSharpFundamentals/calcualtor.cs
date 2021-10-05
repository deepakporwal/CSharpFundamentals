using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class calcualtor
    {
        public static int Square(int num) 
        {
            return num * num;
        }

        public static void WhileLoopEx() 
        {
            int number = 1;
            while(number <5)
            {
                number = number+1;
                Debug.Print(number.ToString());
                if (number == 3) continue; /// skip any interation we use continue statement
                if (number == 4) goto myLabel;
            }

            myLabel: 
            {
                Debug.Print("use go to statement");
            }
        }
    }
}
