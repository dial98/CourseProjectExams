using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers for x,y,z,a and b here:");
            Console.Write("x=");
            double x = int.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = int.Parse(Console.ReadLine());
            Console.Write("z=");
            double z = int.Parse(Console.ReadLine());
            Console.Write("a:");
            double a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            double b = int.Parse(Console.ReadLine());
            double izraz=Math.Pow((y+(6*a)-2)/3*(x+6),6)-(z/(z+7*b));
            Console.WriteLine("At the end the result is:{0}",izraz);
        }
    }
}
