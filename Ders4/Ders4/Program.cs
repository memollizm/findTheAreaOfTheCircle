using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius, area,perimeter;

            Console.Write("Input the radius: ");
            radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************");
            
            perimeter = 2 * Math.PI * radius;
            area = Math.PI * radius * radius;

            Console.WriteLine("Area = "+area);
            Console.WriteLine("Perimeter = "+perimeter);
            Console.ReadKey();
        }
    }
}
