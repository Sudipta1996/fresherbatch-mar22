using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingMent
{
    internal class Params
    {
        public static int Add(params int[] list)
        {
            int total = 0;
            for (int i = 0; i < list.Length; i++)
                total += list[i];
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The Sum of Arry is");
            int total3 = Params.Add(2, 3, 4);
            Console.WriteLine(total3);
            Console.ReadLine();
        }
    }
}
