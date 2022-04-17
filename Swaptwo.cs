using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingMent
{
    internal class Swaptwo
    {
        static void swap()
        {
            int a, b;
            Console.WriteLine("Enter the first Values");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Value ");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swap is:" + a);
            Console.WriteLine("After Swap is " + b);

        }
        static void Main()
        {
            swap();
            Console.ReadKey();
        }
    }
}

