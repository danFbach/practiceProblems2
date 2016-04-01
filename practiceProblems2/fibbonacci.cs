using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceProblems2
{
   public class fibbonacci
    {
        public List<double> fibbonacciSequence = new List<double>();
        public double currentNumber;
        public double tempNumber1 = 0;
        public double iterationLimit = 25;
        public double shiftInput;
        public string anotherSequence = "y";                   
        public string newLine = Environment.NewLine;
        public void newSequence()
        {
            while (anotherSequence.Equals("y"))
            {
                fibbonacciSequence = new List<double>();
                Console.WriteLine("Please enter a shift(number 1 - 10,000) to apply to the Fibbonacci Sequence.");
                shiftInput = double.Parse(Console.ReadLine());
                Console.WriteLine();
                calculateSequence(shiftInput);
                displaySequence();
                Console.WriteLine(newLine + "Would you like to calculate another fibbonacci sequence? (Y/N)" + newLine);
                anotherSequence = Console.ReadLine();
                anotherSequence = anotherSequence.ToLower();
                anotherSequence = anotherSequence.Trim();
            }
        }

        public void calculateSequence(double shift)
        {
            fibbonacciSequence.Add(shift);
            fibbonacciSequence.Add(0);        
            currentNumber = shift;
            fibbonacciSequence.Add(currentNumber);
            for (int nextNum = 0; nextNum < iterationLimit; nextNum += 1)
            {
                tempNumber1 = currentNumber * 2;
                tempNumber1 -= fibbonacciSequence[nextNum];
                fibbonacciSequence.Add(tempNumber1);
                currentNumber = tempNumber1;
            }
        }
        public void displaySequence()
        {
            fibbonacciSequence.RemoveRange(0,2);
            foreach (double digit in fibbonacciSequence)
            {
                Console.Write(digit + ", ");
            }                 
        }
    }
}                 