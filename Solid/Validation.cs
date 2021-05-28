using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
   public class Validation
    {


        public static string Value(Program program)
        {

            string a = (string.IsNullOrWhiteSpace(program.Name)) && (string.IsNullOrWhiteSpace(program.LastName)) ? "Your have enter invalid input": "Your have enter valid input";
            return a;


        }

    }
}
