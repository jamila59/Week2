using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Counter.Models
{
  public class Term
  {
   public string Word  { get; set; } 
   public string Sentence { get; set; }
   public int Counter { get; set; } 
     
  
    public Term(string word, string sentence)
    {
       Word = word;
       Sentence = sentence;
       Counter = 0;
    }
       
        
        public int Match(string word, string sentence)
        {
         string wordUpper = word.ToUpper();
         string sentenceUpper = sentence.ToUpper();
         Console.WriteLine(sentenceUpper);
         string[] sentenceSplit = sentenceUpper.Split(' ');
         for (int i=0; i < sentenceSplit.Length; i++)
         {
           if (sentenceSplit[i] == wordUpper)
           {
             Counter +=1;
           }
         }
          return Counter;  
      }
    }
  }
  
 
  