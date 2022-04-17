using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingMent
{
    internal class Circle
    {
		static void circleCircum()
		{
			Console.WriteLine("Please enter the radius of circle:");
			double radius = Convert.ToDouble(Console.ReadLine());
			double circumCircle = 2 * Math.PI * radius;
			Console.WriteLine("Circumference of circle is: " + circumCircle);
		}
		static void Main(String[] args)
		{
			circleCircum();
			Console.ReadKey();
		}
	}
}
