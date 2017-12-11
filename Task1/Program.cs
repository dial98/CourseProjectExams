using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static void ConvertToBinary()
        {
            
            
        }
        public static void ConvertToOctal()
        {
           
        }

        static void Main(string[] args)
        {
            int num = 2068;

            int remainder;
            string result = string.Empty;
            while (num > 0)
            {
                remainder = num % 2;
                num /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("2068 in binary system is:{0}", result);

            
            int remainder2;
            string result2 = string.Empty;
            while (num > 0)
            {
                remainder2 = num % 8;
                num /= 8;
                result2 = remainder2.ToString() + result2;
            }
            Console.WriteLine("2068 in octal system is: " +result2);
               


    
    }
  }
}

