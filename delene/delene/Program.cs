using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(  "vuvedi edno cqlo 4islo ");
            int a= int .Parse( Console.ReadLine() );
            if (a % 2 == 0)
            {
                Console.WriteLine("4isloto e 4etno");
            }
            else
            {
                Console.WriteLine("4isloto e ne 4etno 6toto e"+ a);
            }
        }
    }
}
