using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1 :
            //Console.WriteLine("Enter your name : ");

            string name = "lujain";
            Console.WriteLine("the name : " + name);

            //Q2
            double d = 40.5;
            Console.WriteLine("double : " + d);
            string str = "lujain string";
            Console.WriteLine("String : " + str);
            int i = 40;
            Console.WriteLine("Integer : " + i);
            char ch = 'L';
            Console.WriteLine("Char : " + ch);
            bool b = true;
            Console.WriteLine("boolean : " + b);
            const string na = "lujain Constant value";
            Console.WriteLine("const : " + na);

            //Q3
            string[] car = { "BMW", "KIA", "VOLVO", "Marcedes" };
            Console.WriteLine(car[0] + " , " + car[1] + " , " + car[2] + " , " + car[3] + " , ");

            //Q4
            string first, last;
            first = "lujain";
            last = "Alnouti";
            int year = 2000;
            Console.WriteLine(first + " " + last + "   " + year);

            //Q5
            int[] numbers = { 1, 2, 5, 4, 7, 8, 6, 23, 2, 455 };
            Console.WriteLine(numbers[0] + " , " + numbers[1] + " , " + numbers[2] + " , " + numbers[3] + " , " + numbers[4] +
                " , " + numbers[5] + " , " + numbers[6] + " , " + numbers[7] + " , " + numbers[8] + " , " + numbers[9]);

            //Q6
            int[] sum = {22,66,88,99};
            Console.Write("the sum = ");
            Console.WriteLine(sum[0] + sum[1] + sum[2] + sum[3]);
            


        }
    }
}
