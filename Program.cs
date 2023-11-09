using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first 10 natural numbers are as follows\n");
            for (int i = 0;i<=10;i++)
            {   
                Console.WriteLine("{0}",i);
            }
            Console.WriteLine("\n");
            int n = 0;
            Console.WriteLine("Even numbers are as follows\n");
            while (n<=10)
            {   
                Console.WriteLine(n);
                n = n + 2;
            }
            int num=0;
            Console.WriteLine("The odd numbers");
            do
            {
                num = num + 1;
                Console.WriteLine(num);
            }while(num<=10);
            Console.ReadKey();
        }
        
    }
}
