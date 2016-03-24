using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeB
{
    class badWordBarker
    {
        List<string> listMain = new List<string>();
        public badWordBarker()
        {

        }
        public string inputWord()
        {
            while (true) {
                Console.WriteLine("Please enter a word");
                string userInput = Console.ReadLine();
                


                while (true)
                {
                    if (listMain.Contains(userInput))
                    {
                        Console.WriteLine("Bark Bark hoe");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Thank you, that word is valid");
                        listMain.Add(userInput);
                        break;
                    }
                }

            }
        }
       
    }
}
