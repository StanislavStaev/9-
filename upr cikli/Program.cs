using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace upr_cikli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());  
            for (var r = 1; r <= n; r++)
            {
                Console.Write("S");
                for (var c = 1; c <= n; c++)
                {
                    Console.Write("S");
                }
                Console.WriteLine();
            }
        }
    }
}
