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
   public int Score { get; set; } 
     
  
    public Term(string word, string sentence)
    {
       Word = word;
       Sentence = sentence;
       Score = 0;
    }

   
    public int RepeatCounter(string word, string sentence)
    {
      string wordUpper = word.ToUpper();
      string sentenceUpper = sentence.ToUpper();
      string[] sentenceSplit = sentenceUpper.Split(' ');
      for (int i=0; i < sentenceSplit.Length; i++)
      {
        if (sentenceSplit[i] == wordUpper)
        {
          Score +=1;
        }
      }
      return Score;  
    }
    public int getScore()
    {
      return Score;
    }

  }
}

 
  