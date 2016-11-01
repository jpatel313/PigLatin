using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_real
{
    public class PigLatinProgram
    {

        public static void Main(string[] args)

        {
            string vowels = ("aeiou");
            int vowelPosition = 0;
            string agree = "y";          
            //string userWords= null;
 
                Console.WriteLine("Welcome to the Pig Latin translator!");
            do
            {

                Console.WriteLine("Enter one word: ");
                string userInput = Console.ReadLine();
                userInput = userInput.ToLower();
                //userInput = userWords;
                //Turn whatever word user types to lowercase.
                //Init userWords for second method

                if (vowels.Contains(userInput[0]))
                    {
                        Console.WriteLine(userInput + "way");
                        //When word starts with vowel, adds "way" to end.
                    }

                    else
                    {
                        vowelPosition = FirstVowelMethod(userInput);
                        Console.WriteLine(userInput.Substring(vowelPosition) + (userInput.Substring(0, vowelPosition) + "ay"));
                        //( where the vowel starts until end of string) + (before vowel position to end of word) +"ay".
                    }
                

                Console.WriteLine("Continue translating?(y/n): ");
                agree = (Console.ReadLine());

            }
                while ((agree == "y") || (agree == "Y"));

        }
                
                  //Method gives the position of the vowel in users word
                  public static int FirstVowelMethod(string userInput)
                  {
                  char[] v = { 'a', 'e', 'i', 'o', 'u' };
                  int vowelPosition = userInput.IndexOfAny(v);
                  return vowelPosition;
                  }
          
        
        /*  
            //method to seperate string with split
         public static string[] TranslateMethod(string userWords)
        {
            string []userWordsArray  = userWords.Split(' ');
            
                StringBuilder userSentence = new StringBuilder()
                string pigLatinSentence;

            foreach (string userWords in userWordsArray)
            {
                pigLatinSentence.Append(TranslateMethod(userWord) + " ");
            }


        }
  
       
                
                   ///TODO:
                      ///use translatemethod to seperate strings with split
                      ///find index of each individual word with firstvowelmethod
                      ///output each ind. string in piglatin

                //LoopResult over arrray for the whole string

                // TranslateMethod(string userWords);

                // FirstVowelMethod(string userInput);
                */

    }
}       
      
    



