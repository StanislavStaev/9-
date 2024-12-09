using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vlagane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(  "vuvedi 4islo");
            var a = Console.ReadLine();
            Console.Write("vuved plod ili zelen4uk");
            var b = Console.ReadLine();
            Console.Write("kakvo si vuvel");
            var c = Console.ReadLine();
            if (a == "2" && b == "plod") 
            {
                Console.Write( "ti si vuvel plod s ime " );
            }
            else
            {
                Console.Write(" tova e zelen4uk ");
            }
            if (a == "3")
            {
                Console.Write("ti si vuvel zelen4uk s imeto krastavica  ");
            }
            else
            {
                Console.Write(" tova e tova e zelen4uk ");
            }

            if (a == "4")
            {
                Console.Write("ti si vuvel zele4uk s imeto domat  ");
            }
            if (a == "5")
            {
                Console.Write("ti si vuvel plot s imeto borovinka  ");
            }
            if (a == "6")
            {
                Console.Write("ti si vuvel plod s imeto oreh  ");
            }

        }
    }
}
