using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum=0;
            
            for (double n = 1; n < 50; n++)
            {                               
                    sum+=Math.Pow(n,(1/n));
                Console.WriteLine("The sum is {0} ", sum);
            }        
        }
    }
}
