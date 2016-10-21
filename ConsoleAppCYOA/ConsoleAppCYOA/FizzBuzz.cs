using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCYOA
{
    public class FizzBuzz
    {
        public void RunFizzBuzz()
        {
            for (int number = 0; number < 100; number++)
            if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
            else if(number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }   
            else if (number % 3  % 5 != 0)
                {
                Console.WriteLine(number);
                }
            Console.ReadLine();   
        }
    }
}
