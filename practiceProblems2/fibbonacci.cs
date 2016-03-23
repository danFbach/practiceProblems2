using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceProblems2
{
    public class fibbonacci
        {
        List<int> fibs1 = new List<int>();
        int tempNumber1 = 0;
        int tempNumber2 = 0;
        int tempResult;
        public void sequence(int shift)
        {
            tempNumber1 = shift;
            for (int i = 0;i < 50;i += 5)
            {                                         tempNumber1 = shift * 2;
                fibs1.Add(tempNumber1);                                                                         
                Console.WriteLine(" " + tempResult);
            } Console.ReadKey();             
        }                                 
    }
}        
