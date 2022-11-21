using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_task_d2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            Console.WriteLine("please enter first integer number Q1");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second integer number Q1"+n1);
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2) Console.WriteLine("the n2 smaller than n1"+n2);
            else Console.WriteLine("the n1 smaller than n2");
            /*---------------------------------------------------------------*/
            Console.WriteLine("-------------------------------------------------");

            //Q2
            Console.WriteLine("please enter integer number Q2");
            int sn = Convert.ToInt32(Console.ReadLine());
            if (sn > 0) Console.WriteLine("The sign is +");
            else Console.WriteLine("The sign is -");

            Console.WriteLine("-------------------------------------------------");
            /*---------------------------------------------------------------*/

            //Q3
            Console.WriteLine("please enter first integer number Q3");
            int fn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second integer number Q3");
            int sen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter third integer number Q3");
            int tn = Convert.ToInt32(Console.ReadLine());



            if (fn > sen && fn > tn)
            {
                Console.Write("Output : " + fn + ",");
                if (tn > sen)
                {
                    Console.Write(tn + ",");
                    Console.Write(sen + ",");
                }
                else
                {
                    Console.Write(sen + ",");
                    Console.Write(tn + ",");
                }

            }
            else if (sen > fn && sen > tn)
            {
                Console.Write("Output : " + sen + ",");
                if (tn > fn)
                {
                    Console.Write(tn + ",");
                    Console.Write(fn + ",");
                }
                else
                {
                    Console.Write(fn + ",");
                    Console.Write(tn + ",");
                }

            }
            else
            {
                Console.Write("Output : " + tn + ",");
                if (sen > fn)
                {
                    Console.Write(sen + ",");
                    Console.Write(fn + ",");
                }
                else
                {
                    Console.Write(fn + ",");
                    Console.Write(sen + ",");
                }
            }

            /*---------------------------------------------------------------*/
            Console.WriteLine("-------------------------------------------------");

            //Q4
            Console.WriteLine("please enter first integer number Q4");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second integer number Q4");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter third integer number Q4");
            int third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter fourth integer number Q4");
            int forth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter fifth integer number Q4");
            int fifth = Convert.ToInt32(Console.ReadLine());

            if (first > second && first > third && first > forth && first > fifth)
            {
                Console.Write("Output : " + first + ",");
            }
            else if (first < second && second > third && second > forth && second > fifth)
            {
                Console.Write("Output : " + second + ",");
            }
            else if (third > second && first < third && third > forth && third > fifth)
            {
                Console.Write("Output : " + third + ",");
            }
            else if (forth > second && forth > third && first < forth && forth > fifth)
            {
                Console.Write("Output : " + forth + ",");
            }
            else Console.Write("Output : " + fifth + ",");
            /*---------------------------------------------------*/
            Console.WriteLine("-------------------------------------------------");

            //Q5

            Console.WriteLine("Input kilometers per hour:  Q5");
            double killo = Convert.ToInt32(Console.ReadLine());
            double mills = killo * 0.621371;
            Console.WriteLine(mills + "miles per hour");

            /*---------------------------------------------------*/
            Console.WriteLine("-------------------------------------------------");

            //Q6

            Console.WriteLine("•\tInput hours:   Q6");
            int H = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("•\tInput minutes:  Q6");
            int M = Convert.ToInt32(Console.ReadLine());
            int total_m = (H * 60) + M;
            Console.WriteLine("Total:" + total_m + "minutes");
            /*-------------------------------------------------*/
            Console.WriteLine("-------------------------------------------------");

            //Q7
            Console.WriteLine("•\tInput minutes:   Q6");
            int mini = Convert.ToInt32(Console.ReadLine());
            int x = mini / 60;
            int min = mini % 60;
            Console.WriteLine(x+ " Hours, "+min+ " Minutes");



            /*----------------------------------------------------*/
            Console.WriteLine("-------------------------------------------------");

            //Q8
            string[] str = { "Hello World !", "My name is Lujain", "Alnouti", "Hiiiiiiii", "Orange" };
            Console.WriteLine(str[0] + "  length : " + str[0].Length);
            Console.WriteLine(str[1] + "  length : " + str[1].Length);
            Console.WriteLine(str[2] + "  length : " + str[2].Length);
            Console.WriteLine(str[3] + "  length : " + str[3].Length);
            Console.WriteLine(str[4] + "  length : " + str[4].Length);
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(str[0].Substring(0,6));
            Console.WriteLine(str[1].Substring(0, 6));
            Console.WriteLine(str[2].Substring(0, 6));
            Console.WriteLine(str[3].Substring(0, 6));
            Console.WriteLine(str[4].Substring(0, 6));
        }
       
        
        
    }
}
