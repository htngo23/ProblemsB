using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeB
{
    class ShapeMaker
    {
        List<List<string>> makeTriangleList = new List<List<string>>();
        List<List<string>> makeBackTriangleList = new List<List<string>>();
        List<List<string>> makeUpsideTriangleList = new List<List<string>>();
        string innerContent = "*";

        public ShapeMaker()
        {

        }
        public int makeRegTriangle(int rotations)
        {
            for(int outterIndex = 0; outterIndex < rotations; outterIndex++)
            {
                makeTriangleList.Add(new List<string>());

                for (int inIndex = 0; inIndex < outterIndex +1 ; inIndex++)
                {
                    makeTriangleList[outterIndex].Add(innerContent);
                   
                }
                   }
            return rotations;
            
        }
     
        public int makeUpsideTriangle(int rotations)
        {
            for (int outterIndex = 0; outterIndex < rotations; outterIndex++)
            {
                makeUpsideTriangleList.Add(new List<string>());

                for (int inIndex = rotations - 1; inIndex > outterIndex - 1; inIndex --)
                {
                    makeUpsideTriangleList[outterIndex].Add(innerContent);

                }
            }
            return rotations;

        }
        public int makeBackTriangle(int rotations)
        {
          
            for (int outterIndex = 0;  outterIndex < rotations ; outterIndex++)
            {
                makeBackTriangleList.Add(new List<string>());

                for(int middleIndex = rotations -1; middleIndex > outterIndex - 1; middleIndex--)
                {
                    makeBackTriangleList[outterIndex].Add(" ");
                }

                for (int inIndex = 0; inIndex < outterIndex ; inIndex++)
                {
                    makeBackTriangleList[outterIndex].Add(innerContent);

                }
            }
            return rotations;
        }

        public bool printRegTriangle()
        {
            foreach (List<string> rotations in makeTriangleList)
            {
                
                foreach (string innercontent in rotations)
                {
                    
                    Console.Write(innercontent);
                    

                }
                Console.WriteLine();
            }
            
            return true;
        }
        public bool printBackTriangle()
        {
            foreach (List<string> rotations in makeBackTriangleList)
            {

                foreach (string innercontent in rotations)
                {

                    Console.Write(innercontent);


                }
                Console.WriteLine();
            }

            return true;
        }

        public bool printUpsideTriangle()
        {
            foreach (List<string> rotations in makeUpsideTriangleList)
            {

                foreach (string innercontent in rotations)
                {

                    Console.Write(innercontent);


                }
                Console.WriteLine();
            }

            return true;
        }

    }
}
