using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prez_cikul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var i=1;
            //for ( i = 1; i <=1000; i++)
            //{
            // if (i % 10 == 4)
            // Console.Write(i+"i=/");
            // }
            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y=");
            int y = int.Parse(Console.ReadLine());
            var p = 0;
            int b = 99;
            for (int i = 0; i < 99; i++)
            {
                p = (a*x) / (b*y) + p;
            }
        }
    }
}
