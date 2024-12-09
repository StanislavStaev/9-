using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(  "n=");
            int n = int.Parse( Console.ReadLine() );
            int num = 1;
            while (num <= n)
            {
                num++;
                if (num % 2 ==0)
                {
                    Console.WriteLine(num); 
                }
            }
        }
    }
}
