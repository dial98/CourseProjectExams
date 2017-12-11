using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter here what area you want me to calculate? (circle, triangle or rectangle)");
            string figureType = Console.ReadLine().ToLower();
            switch(figureType)
            {
                case "circle":
                    Console.WriteLine("Enter radius:");
                    double radius = double.Parse(Console.ReadLine());
                    double circleArea =(radius*radius*Math.PI);
                    Console.WriteLine("The area of a circle is:{0}",circleArea);
                    break;
                case "triangle":
                    Console.WriteLine("Enter side a:");
                    double sideA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter height:");
                    double height = double.Parse(Console.ReadLine());
                    double triangleArea =(sideA*height)/2;
                    Console.WriteLine("The triangle area is:{0}",triangleArea);
                    break;
                case "rectangle":
                    Console.WriteLine("Enter side a (width):");
                    double width = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter side b (length");
                    double length = double.Parse(Console.ReadLine());
                    double rectangleArea =width * length;
                    Console.WriteLine("The rectangle area is:{0}", rectangleArea);
                    break;
            }
        }
    }
}
