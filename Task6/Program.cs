using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void array (double [] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                
                input[i] = double.Parse(Console.ReadLine());
            }
        }
        static void norain(double[]input)
        {            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 0)
                {
                    Console.WriteLine("Ден номер {0}", i + 1);
                }
            }
          }       
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                
                Console.WriteLine("Въведете дни от месеца: ");
                n = Convert.ToInt32(Console.ReadLine()); Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Въведете количеството валежи съответно за всяка от станциите:");
            }
            while (n < 1 || n > 31);
            double[] A = new double[n];
            array(A);
            double[] B = new double[n];
            array(B);
            double[] C = new double[n];
            array(C);
            Console.WriteLine("За станция А"); norain(A);
            Console.WriteLine("За станция B"); norain(B);
            Console.WriteLine("За станция C"); norain(C);
        }
    }
}
