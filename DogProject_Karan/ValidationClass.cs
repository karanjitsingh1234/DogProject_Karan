using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogProject_Karan
{
   public class ValidationClass
    {
        Random random = new Random();
        public Boolean checkNumber(TextBox txt) {

            Regex regex = new Regex("[0-9]");
            if (regex.IsMatch(txt.Text.ToString()))
            {
                return true;
            }
            else {
                return false;
            }
        }
        //code to generate the random no with the help of random class 
        public int genRandomNo() {
            return random.Next(20);
        }



    }
}
