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
        public string proceed = "y";
        public List<string> listOfWords = new List<string>();
        public void getNewWord()
        {
            Console.WriteLine("Please enter a word.");
            userInput = Console.ReadLine();
            userInput = userInput.ToLower();
            userInput = userInput.Trim();                   
        }                  
        public string checkWord()
        {
            foreach(string word in listOfWords)
                {
                if (userInput == word)
                {
                    Console.WriteLine("BARK!");
                    Console.WriteLine("Would you like to contine checking words? (y/N)");
                    proceed = Console.ReadLine();
                    proceed = proceed.ToLower();
                }           
            }Console.WriteLine("Nice word dude.");
            listOfWords.Add(userInput);
            return proceed;
        }
        public void initiateWordCheck()
        {
            while (proceed.Equals("y"))
            {
                getNewWord();
                checkWord();  
            }
        }
    }
}
