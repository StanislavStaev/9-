using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write( "ot koe 4islo da zapo4na " );
            int n= int.Parse( Console.ReadLine() );
            Console.Write("num= ");
            int num= int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine(num);
                num = 2 * num + 1;
            }
            while (num <1 );
        }
    }
}
