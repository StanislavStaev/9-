using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trapec
{
    internal class trapec
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete stoinosti");
            Console.Write("b1=");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("b2=");
            double h = double.Parse(Console.ReadLine());
            Console.Write("h=");
            double b2 = double.Parse(Console.ReadLine());
            double P = (b1+b2)*h/2;
            Console.WriteLine($"lice na trapec:{P} ");
        }
    }
}
