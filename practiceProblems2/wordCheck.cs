using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceProblems2
{
    public class wordCheck
    {
        public string userInput;
        public List<string> listOfWords = new List<string>();
        public void getNewWord()
        {
            Console.WriteLine("Please enter a word.");
            userInput = Console.ReadLine();                    
        }

        public void checkWord()
        {
            foreach(string word in listOfWords)
                {
                if (userInput == word)
                {
                    Console.WriteLine("BARK!");
                }

            }Console.WriteLine("Nice word dude.");
            listOfWords.Add(userInput);
        }
    }
}
