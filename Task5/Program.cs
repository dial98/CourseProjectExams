using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете стойностите на една смесена дроб:");
            Console.WriteLine("Въведете цялата част:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете числителят от дробната част");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете знаменателя от дробната част:");
            int c = int.Parse(Console.ReadLine());
            if (b != 0 && c != 0)
            {
                a = (b / c) + a;
                b = b % c;
                Console.WriteLine("Съкратената цяла част е:{0}", a);
                Console.WriteLine("Съкратеният числител е:{0}", b);
                Console.WriteLine("Съкратеният знаменател е:{0}", c);
            }
          
            if(b==0||c==0)
            {
                Console.WriteLine("Числителят и знаменателят не трябва да са равни на 0!");
            } 
            
        }
    }
}
