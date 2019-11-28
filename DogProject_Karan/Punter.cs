using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogProject_Karan
{
  public abstract class Punter
    {
        Random random = new Random();
        public int genRandomNo()
        {
            return random.Next(20);
        }

        public int findWinner(int z,int dog,int amt) {
            if (z==dog) {
                return amt;
            }
            else {
                return -amt;
            }
        }

    }
}
