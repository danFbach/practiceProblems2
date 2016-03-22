using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceProblems2
{
    public class shapeMaker
    {
        public List<List<string>> shape = new List<List<string>>();
        
        public void square(int dimensions)
        {                                                                
            for (int rowIndex = 0; rowIndex < dimensions; rowIndex++)
            {    
                shape.Add(new List<string>());

                for (int colIndex = 0; colIndex < rowIndex+1; colIndex++)
                {
                    shape[rowIndex].Add("*");
                }
            }
        }
        public void printThis()
        {
            foreach (List<string> row in shape)
            {
                Console.WriteLine();

                foreach (string star in row)
                {
                    Console.Write(star);
                }
            }  Console.Read();
        }
    }
}