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
           if (string.IsNullOrEmpty(userSentence) == true)
           {
                Console.WriteLine("Invalid input, try again.");
                Console.WriteLine("Enter a sentence:");
                userSentence = Console.ReadLine();
                
            }       
            
        }
    }
}