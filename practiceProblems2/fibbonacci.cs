using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceProblems2
{
    public class fibbonacci
    {
        List<double> fibs1 = new List<double>();
        double currentNumber;
        double tempNumber1 = 0;
        double iterationLimit = 50;
        public void sequence(double shift)
        {
            fibs1.Add(shift);
            fibs1.Add(0);        
            currentNumber = shift;
            fibs1.Add(currentNumber);
            for (int nextNum = 0; nextNum < iterationLimit; nextNum += 1)
            {
                tempNumber1 = currentNumber * 2;
                tempNumber1 -= fibs1[nextNum];
                fibs1.Add(tempNumber1);
                currentNumber = tempNumber1;
            }
        }
        public void printFibbbbb()
        {
            foreach (double fib in fibs1)
            {
                Console.WriteLine(fib);
            }                 
        }
    }
}                 