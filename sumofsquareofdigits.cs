using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication106
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            int num = Convert.ToInt32(Console.ReadLine());
            double  sum = num.ToString().Sum(c =>  Math.Pow((c - '0'),2));
            Console.WriteLine("\n");
            Console.WriteLine("The sum Value={0}", sum);
            Console.ReadLine();
        }
    }
}
