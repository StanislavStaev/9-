using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formuli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi stoinost na x i y");
            Console.Write("x=");
            var x= double.Parse(Console.ReadLine());
            Console.Write("y=");
            var y = double.Parse(Console.ReadLine());
            var z = Math.Round (2 * x * y * y + 4 * 5 / (20 * x * y * y * y),4);
            Console.WriteLine("z=" +z);
            Console.WriteLine(Math.Round(z,4));
            Console.WriteLine(Math.Ceiling(z));
            Console.WriteLine(Math.Floor(z));

        }
    }
}
