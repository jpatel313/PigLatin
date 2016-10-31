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
            Console.WriteLine("Enter one word: ");
            string userInput = Console.ReadLine();//USER INPUT
            userInput = userInput.ToLower();//USER INPUT to all lowercase
            string vowels = ("aeiou");
            int vowelPosition = 0;
            bool agree = true;

            while (agree)
            {
                if (vowels.Contains(userInput[0]))
                {
                    Console.WriteLine(userInput + "way");
                }

                else
                {
                    vowelPosition = FirstVowelMethod(userInput);
                    Console.WriteLine(userInput.Substring(vowelPosition) + (userInput.Substring(0, vowelPosition) + "ay"));
                }
            }

            Console.WriteLine("Continue translating?(y/n): ");
            string agreeResponse  = Console.ReadLine();

            if ((agreeResponse == "y")|| (agreeResponse == "Y"))
            {
                agree = true;
            }
     
        }
                
            

            public static int FirstVowelMethod(string userInput)
        {
            char[] v = { 'a', 'e', 'i', 'o', 'u' };
            int vowelPosition = userInput.IndexOfAny(v);
            return vowelPosition;
        }
        
}
}       
      
    



