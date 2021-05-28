using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
  public  class CaptureName
    {
        public static Program Capturename()
        {
            Program user = new Program();

            Start.Fname();
            user.Name = Console.ReadLine();
            Start.Lname();
            user.LastName = Console.ReadLine();

            return user;
        }
    }
}
