using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //прожерява дали сме въвели от 1 до сто
            //ако е под 1 и над 100 изкаржа съобщение
            Console.Write("VUVEDI EDNO 4ISLO ");
            int num = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("ti si super");
                num = int.Parse(Console.ReadLine());
            }
            while (num > 1 && num < 100) ;
            Console.WriteLine("the number is: {0} i e pod diapazona 1-100", num);
        }
    }
}
