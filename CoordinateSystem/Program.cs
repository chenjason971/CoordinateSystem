using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program determines where your coordinate point lies");
            Console.WriteLine("_________________________________________________________");
            Console.Write("\n \n");

            Console.WriteLine("Enter your x coordinate: \n");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your y coordinate: \n");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.Write("The coordinate point ({0} {1}) lies in the First quandrant.\n\n", x, y);
            else if (x < 0 && y > 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Second quandrant.\n\n", x, y);
            else if (x < 0 && y < 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Third quandrant.\n\n", x, y);
            else if (x > 0 && y < 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Fourth quandrant.\n\n", x, y);
            else if (x == 0 && y == 0)
                Console.Write("The coordinate point ({0} {1}) lies at the origin.\n\n", x, y);

            Console.ReadKey();
        }
    }
}
