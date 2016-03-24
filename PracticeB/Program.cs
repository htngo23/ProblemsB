using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeB
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeMaker shapes = new ShapeMaker();
            badWordBarker p1 = new badWordBarker();
            fibs p3 = new fibs();
            test trial = new test();
            Construction p4 = new Construction("https://www.youtube.com/watch?v=hl_9_q_uLF8");

            // shapes.makeRegTriangle(5);
            // shapes.printRegTriangle();
            //shapes.makeUpsideTriangle(5);
            //shapes.printUpsideTriangle();
            // shapes.makeBackTriangle(5);
            // shapes.printBackTriangle();
            //p1.inputWord();
            //  p3.fib();
          
            Console.ReadLine();
        }
    }
}
