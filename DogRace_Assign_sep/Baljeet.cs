using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace_Assign_sep
{
   public class Baljeet
    {

        //global variable to pass the value 
        int betAmount = 0, dog = 0, winner = 0, budget = 0;

        //default constructor
        public Baljeet()
        {

        }

        //paramterized constructor of the class
        public Baljeet(int Budget, int Dog, int BetAmount)
        {
            //pass the value to the global variable 
            budget = Budget;
            dog = Dog;
            
            betAmount = BetAmount;
        }


        public int checkResult(int Winner)
        {
            if (dog == Winner)
            {
                budget += betAmount;
            }
            else
            {
                budget -= betAmount;
            }
            return budget;
        }



    }
}
