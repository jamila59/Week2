using System;
using System.Collections.Generic;
using System.Linq;
using Counter.Models;


namespace Project.Models
{
    class Program
    {
         public static void Main()
        {
           Console.WriteLine("Enter a sentence:");
           string userSentence = Console.ReadLine();
           if (string.IsNullOrEmpty(userSentence) == true )
           {
                Console.WriteLine("Invalid input, try again.");
                Console.WriteLine("Enter a sentence:");
                userSentence = Console.ReadLine();
                
            }   
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Enter a word:");
            string userWord = Console.ReadLine();
            if (string.IsNullOrEmpty(userWord) == true )
            {
                Console.WriteLine("Invalid input, try again.");
                Console.WriteLine("Enter a word:");
                Console.WriteLine("---------------------------------");
                userWord = Console.ReadLine();
            }
            Term user = new Term(userWord, userSentence);
            user.RepeatCounter(userWord, userSentence);
            Console.WriteLine("---------------------------------");
            Console.WriteLine(" "+ userWord + "  appears  " + user.getScore()+ "  " + "time(s) in the sentence.");
            Console.WriteLine("---------------------------------");
        }
    }
}   

