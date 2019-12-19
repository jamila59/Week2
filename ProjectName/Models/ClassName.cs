using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
  public class Change
  {
      public int Quarters; 
      public int Dimes;  
      public int Nickles;   //ask why code doesnt work when get/set are added
      public int Pennies;  
      public double Total;  

  
    public Change(double total, int quarters, int dimes, int nickles, int pennies)
    {
        Quarters = quarters;
        Dimes = dimes;
        Nickles = nickles;
        Pennies = pennies;
        Total = total;
    }
        public int getQuarters()
        {
            return Quarters;
        }

        public int getDimes()
        {
            return Dimes;
        }
        public int getNickles()
        {
            return Nickles;
        }

        public int getPennies()
        {
            return Pennies;
        }
    

        
        public void ChangeConverter(double total)
        {
            while (total > 0)
            { 
                if (total >= 0.25)
                {
                  total -= 0.25;
                  Quarters ++;
                }
                if(total >= 0.10)
                {
                    total -= 0.10;
                    Dimes++;
                }
                if(total >= 0.05)
                {
                    total -= 0.05;
                    Nickles++;
                }
                if  (total >= 0.01); 
                {
                    total -= 0.01;
                    Pennies++;
                }
            }
        }
    }
  }
 
  