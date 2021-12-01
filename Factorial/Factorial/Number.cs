using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial
{
    class Number
    {
        int number;

        public Number(int number)
        {
            this.number = number;

        }
        public void Factorial()
        {
            int factorial = 1;
            if (this.number < 0)
            {
                Console.WriteLine("Wrong number!");
            }
            else if(this.number == 0)
            {
                Console.WriteLine(this.number);
            }  
            else
            {
                for (int i = 1; i <= this.number; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine(factorial);
            }
        }
    }
}
