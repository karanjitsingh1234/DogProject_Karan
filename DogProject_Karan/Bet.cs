using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogProject_Karan
{
    static  class Bet
    {
       public static int chckBet(int amount) {
            if (amount<=50) {
                return 1;
            }
            else {
                return 0;
            }
        }

    }
}
