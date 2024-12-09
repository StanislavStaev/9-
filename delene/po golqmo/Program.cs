using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_golqmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi edno cqlo 4islo ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("vuvedi o6te edno cqlo 4islo ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("max e" + a);
                Console.WriteLine("min e" + b);
            }
            else
            {
                Console.WriteLine("min e" + b);
                Console.WriteLine("max e" + a);
            }
        }
    }
}
