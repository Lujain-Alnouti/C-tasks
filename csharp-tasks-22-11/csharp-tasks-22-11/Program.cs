using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tasks_22_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //	string [ ] ARR= [ 1,7  9  45, ]
            int[] ARR = { 1, 7, 9, 45 };
            //•	int arr2=["Str" "alex","moh"
            string[] ARR2 = { "Str", "alex", "moh" };
            //•	string arr3= 'the','fox' 'over' lazy, 'dog',  ]
            string[] ARR3 = { "the", "fox ", "over", "lazy", "dog" };
            Console.WriteLine("***************************");
            //Q2
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == "Tomato")
                    Console.WriteLine("the Tomatgo index is : " + i);
                if (fruits[i] == "Banana")
                    Console.WriteLine("The Banana index is : " + i);
            }
            Console.WriteLine("***************************");
            //Q3
            string[] Food = { "Apple", "Orange", "Mango", "Banana", "Watermelon" };
            string[] Sport = { "Football", "Handball", "swiming" };
            string[] Movie = { "Adam and the Devil", "Red Notice", "Run", "Adam" };

            Console.WriteLine("print food array using foreach :");
            foreach (string f in Food)
            {
                Console.WriteLine(f);
            }
            //Console.WriteLine("print food array using for-loop :");
            //for(int i =0; i < Food.Length; i++)
            //{
            //    Console.WriteLine(Food[i]);
            //}
            Console.WriteLine("print sport array using foreach :");
            foreach (string f in Sport)
            {
                Console.WriteLine(f);
            }
            //Console.WriteLine("print sport array using for-loop :");
            //for (int i = 0; i < Sport.Length; i++)
            //{
            //    Console.WriteLine(Sport[i]);
            //}
            Console.WriteLine("print movie array using foreach :");
            foreach (string f in Movie)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine("print movie array using for-loop :");
            for (int i = 0; i < Movie.Length; i++)
            {
                Console.WriteLine(Movie[i]);
            }
            Console.WriteLine("*************Q4**************");
            //Q4

            Console.WriteLine("please enter 3 number in same line and separeted between us using ','");
            string num = Console.ReadLine();
            string[] numbers = num.Split(',');
            int[] x = new int[numbers.Length];
            int s = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                x[i] = int.Parse(numbers[i]);
                s += x[i];
            }
            Console.WriteLine("the sumation is : " + s);

            Console.WriteLine("*************Q5**************");
            //Q5
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                    sum += i;
                else continue;
            }
            Console.WriteLine("The Sum of odd Numbers is: " + sum);

            Console.WriteLine("*************Q6**************");
            //Q6
            for (int i = 0; i < 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int x1 = 0; x1 <= i; x1++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }



            Console.WriteLine("*************Q7**************");
            //Q7
            int x5 = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int x1 = 1; x1 <= i; x1++)
                {
                    Console.Write(x5 + " ");
                    x5++;
                }
                Console.WriteLine("");
            }

            // string f = Console.ReadLine();
            // string[] nums = f.Split(',');
            // int[] x1 = new int[nums.Length];
            // int[] x2 = new int[] { };
            // int sum = 0;
            // int c = 0;

            // for (int i = 0; i < nums.Length; i++)
            // { 
            //     x1[i] = Convert.ToInt32(nums[i]);
            // }

            // sum = sum + x1[0];
            //for (int a = 1; a < x1.Length; a++)
            //     {
            //     for (int d = 0; d < a; d++)
            //     {
            //         if (x1[a] == x1[d])
            //         {
            //             x1[a] = 0;

            //         }
            //          sum += x1[a];
            //     }

            //     }
            //     //foreach(int x in x1)
            //     //  {
            //     //if(x==0) { c++; }
            //     //      }
            //     for(int k=0; k < x1.Length;k++)
            //           {
            //     if (x1[k] == 0)
            //     {
            //         c++;
            //     }
            // }


            //     Console.WriteLine(sum / (x1.Length - c));

        }
    }
}
