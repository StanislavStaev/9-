using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smqtane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" vuvedi 1 tricifreno chislo");
            int a = int .Parse(Console.ReadLine());
            double s, d, e ,t ,b;
            s = a / 100;
            d = a % 100/10;
            e = a % 100 / 10;
            t = a  % 100 % 100 /10;
            b = a  % 100 % 100 % 10/1;
            Console.WriteLine($"s= {s} , d = {d} , e= {e} t= {t} b={b}" );
               
        }
    }
}
