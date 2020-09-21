using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace_Assign_sep
{
    class Runner
    {
        Random rd = new Random();
        //code to genereate the value to jump from one part to anther by dog
        public int jumpLength() {
            return rd.Next(1, 40);
        }
    }
}
