using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeB
{
    class Construction
    {
        public Construction(string n)
        {
           System.Diagnostics.Process.Start(n);
            

        }
         ~Construction()
        {
            Console.WriteLine("whoa");     }
    }
}
