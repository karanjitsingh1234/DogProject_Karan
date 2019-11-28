using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogProject_Karan
{
    static class Karan
    {
        static int verfy(int amt,int dog) {
            if (Bet.chckBet(amt) == 1)
            {
                return 1;
            }
            else {
                return 0;
            }
        }
    }
}
