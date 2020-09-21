using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace DogRace_Assign_sep
{
    public class Sukh
    {
        //global variable to pass the value 
        int betAmount = 0, dog = 0,budget=0;

        //default constructor
        public Sukh() {
                
        }
        
        //paramterized constructor of the class
        public Sukh(int Budget,int Dog,int BetAmount) {
            //pass the value to the global variable 
            budget = Budget;
            dog = Dog;
            betAmount = BetAmount;
        }


        public int checkResult(int Winner) {
          //  MessageBox.Show("--" + Winner + "---" + budget + "---" + dog+"---"+betAmount);
            if (dog == Winner)
            {
                budget = budget+ betAmount;
                return budget;
            }
            else {
                budget= budget- betAmount;
                return budget;
            }
            
        }

    }
}
