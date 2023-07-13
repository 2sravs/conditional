using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_op
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conditional op
            int num1, num2;
            Console.WriteLine("Enter First Number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2 = int.Parse(Console.ReadLine());
            var result = num1 > num2 ? "First Number is greater" : "Second Number is Greater";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
