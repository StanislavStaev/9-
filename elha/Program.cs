using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n= int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                var stars = new string('$', i);
                var spaces = new string(' ', n - i);
                Console.Write(spaces);
                Console.Write(" * " );
                Console.Write(stars);
                Console.Write(" * ");
                Console.WriteLine(stars);
                Console.WriteLine(spaces);
                Console.WriteLine("*");
            }
            for (int i =n ; i >= 1; i--)
            {
                var spaces = new string('$',  i);
                var stars = new string(' ',n-i);
                Console.Write(stars);
                Console.Write(" * " );
                Console.Write(spaces);
                Console.WriteLine(spaces);
                Console.Write(" * ");
                Console.WriteLine(stars);
                Console.Write(" * ");


            }
        }
    }
}
