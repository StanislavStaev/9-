using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upr_cikul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int S = 0;
            Console.Write("N=");
            int N = int.Parse(Console.ReadLine());
            for (int a = 1; a <= N; a++)
            {
                 S = a + S;
                Console.WriteLine(S);
            }
        }
    }
}
