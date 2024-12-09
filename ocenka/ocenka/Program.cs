using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocenka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kakva ocenka iska6 ");
            double a = double.Parse(Console.ReadLine());
            if (a == 2)
            {
                Console.Write("slab 2");
            }
            if (a <= 3.49)
            {
                Console.Write("sreden 3");
            }
            
            else
            if (a >= 3.50)
            {
                Console.Write("dobur 4");
            }
            else
            if (a == 0)
            
                Console.Write("nqma tukava ocenka");
            }
            }
            }
            
