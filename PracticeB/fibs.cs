using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeB
{
    class fibs
    {
        public void fib()
        {
          
            List<int> numList = new List<int>();

            Console.WriteLine("Insert starting number to be fibbed");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;

               

            for (int i = 0; i < 100; i++)
            {
                int temp = a + b;
                b = a;
                a = temp;
                Console.WriteLine(a);
            }
        

        }
        
    }
}
