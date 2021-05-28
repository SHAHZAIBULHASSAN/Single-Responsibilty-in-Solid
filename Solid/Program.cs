using System;

namespace Solid
{
   public class Program
    {     public string Name { get; set; }
           public string LastName { get; set; }
        static void Main(string[] args)
        {
           


            Start.SB();

          Program pro= CaptureName.Capturename();
            string bol = Validation.Value(pro);
            Start.INvalid(bol);
          //  FullName fi = new FullName();
            FullName.Full(pro);
            End.mesg();
        }
    }
}
