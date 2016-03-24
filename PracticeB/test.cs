using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeB
{
    public class test
    {
        public static int NthFibonacciNumber(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return (NthFibonacciNumber(n - 1) + NthFibonacciNumber(n - 2));
            }
        }

        public void doIt() 
        {
            Console.Write("Enter the nth number of the Fibonacci Series: ");
            int number = Convert.ToInt32(Console.ReadLine());
            number = number - 1;
            //We have to decrement the length because the series starts with 0  

            Console.Write(NthFibonacciNumber(number));
            Console.ReadKey();
        }
    }
}