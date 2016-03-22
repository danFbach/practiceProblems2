using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceProblems2
{
    class Program
    {
        static void Main(string[] args)
        {
            //wordCheck check = new wordCheck();
            //while (true)
            //{
            //    check.getNewWord();
            //    check.checkWord();
            //}

            shapeMaker makeShape = new shapeMaker();
            makeShape.square(5);
            makeShape.printThis();
        }
    }
}
