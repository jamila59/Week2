using System;
using System.Collections.Generic;
using System.Linq;


namespace Project.Models
{
    class Program
    {
         public static void Main()
        {
            Console.WriteLine("Enter amount you want");
            int userInput = int.Parse(Console.ReadLine());
            Change user = new Change(userInput,0,0,0,0);
            user.ChangeConverter(userInput);
            Console.WriteLine("Quarters" + "" + user.getQuarters());
            Console.WriteLine("Dimes" + "" +user.getDimes());
            Console.WriteLine("Nickes" +user.getNickles());
            Console.WriteLine("Pennies" + "" +user.getPennies());
        }
    }
}