using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceProblems2
{
    public class shapeMaker
    {
        public string makingTriangles = "y";
        public int triangleSelection;
        public int dimensionInput;
        public string newLine = Environment.NewLine;
        public List<List<string>> shape = new List<List<string>>();

        public void drawTriangles() {
            while (makingTriangles.Equals("y"))
            {
                shape = new List<List<string>>();
                Console.WriteLine("What type of triangle would you like to see?" + newLine + "1. Standard Triangle " + newLine + "2. Backwards Triangle " + newLine + "3. Upside Down Triangle " + newLine + "4. *BONUS* Upside Down Backwards Triangle" + newLine + "Please enter 1, 2, 3 or 4." + newLine);
                triangleSelection = int.Parse(Console.ReadLine());
                Console.WriteLine("And what size of triangle would you like?" + newLine + "Please enter a number 1 - 100.");
                dimensionInput = int.Parse(Console.ReadLine());

                if (triangleSelection.Equals(1))
                {
                    standardTri(dimensionInput);
                }
                else if (triangleSelection.Equals(2))
                {
                    BackwardsTri(dimensionInput);
                }
                else if (triangleSelection.Equals(3))
                {
                    upsidedownTri(dimensionInput);
                }
                else if (triangleSelection.Equals(4))
                {
                    upsidedownBackwardsTri(dimensionInput);
                }
                Console.WriteLine(newLine + "Would you like to make another triangle? (Y/N)");
                makingTriangles = Console.ReadLine();
                makingTriangles = makingTriangles.ToLower();
            }
        }
        public void upsidedownBackwardsTri(int dimensions)
        {
            for (int rowindex = 0; rowindex < dimensions; rowindex++)
            {
                shape.Add(new List<string>());
                for (int colindex = 0; colindex < rowindex; colindex++)
                {
                    shape[rowindex].Add(" ");
                }
                for (int colindex = dimensions + 1; colindex > rowindex + 1; colindex--)
                {
                    shape[rowindex].Add("*");
                }
            }
            foreach (List<string> row in shape)
            {
                Console.WriteLine();
                foreach (string star in row)
                {
                    Console.Write(star);
                }
            }              
        }

        public void standardTri(int dimensions)
        {
            for (int rowIndex = 0; rowIndex < dimensions; rowIndex++)
            {
                shape.Add(new List<string>());
                for (int colIndex = 0; colIndex < rowIndex + 1; colIndex++)
                {
                    shape[rowIndex].Add("*");
                }
                for (int colIndex = dimensions + 1; colIndex > rowIndex + 1; colIndex--)
                {
                    shape[rowIndex].Add(" ");
                }

            }
            foreach (List<string> row in shape)
            {
                Console.WriteLine();
                foreach (string star in row)
                {
                    Console.Write(star);
                }
            }               
        }

        public void BackwardsTri(int dimensions)
        {
            for (int rowIndex = 0; rowIndex < dimensions; rowIndex++)
            {
                shape.Add(new List<string>());
                for (int colIndex = dimensions; colIndex > rowIndex; colIndex--)
                {
                    shape[rowIndex].Add(" ");
                }
                for (int colIndex = 0; colIndex < rowIndex + 1; colIndex++)
                {
                    shape[rowIndex].Add("*");
                }

            }
            foreach (List<string> row in shape)
            {
                Console.WriteLine();
                foreach (string star in row)
                {
                    Console.Write(star);
                }
            }               
        }

        public void upsidedownTri(int dimensions)
        {
            for (int rowIndex = 0; rowIndex < dimensions; rowIndex++)
            {
                shape.Add(new List<string>());
                for (int colIndex = dimensions; colIndex > rowIndex; colIndex--)
                {
                    shape[rowIndex].Add("*");
                }
                for (int colIndex = 0; colIndex < rowIndex + 1; colIndex++)
                {
                    shape[rowIndex].Add(" ");
                }

            }
            foreach (List<string> row in shape)
            {
                Console.WriteLine();
                foreach (string star in row)
                {
                    Console.Write(star);
                }
            }               
        }
    }
}