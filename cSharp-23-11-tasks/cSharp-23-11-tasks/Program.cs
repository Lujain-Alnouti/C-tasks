using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_23_11_tasks
{
    internal class Program
    {
       //********************Q1**************************
        static void sum(int[] arr)
        { double s = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                s += arr[i];
            }
            double avg = s / 10;
            Console.WriteLine("The sum of 10 no is : "+s);
            Console.WriteLine("The Average is : " + avg);
        }

        //********************Q2**************************
        static int cube(int a)
        {
            return (a*a*a);
        }

        //********************Q3**************************
        static void arr(int[] years)
        {
            for (int j = 0; j < years.Length; j++)
            {
                if (years[j] > 1950)
                {
                    Console.Write(years[j]+"  ");
                }
            }
         Console.WriteLine(" ");
        }
        //********************Q4**************************
        static int ageiny(int a)
        {
            return a * 365;
        }
        //***************Q5*****************
        static int animal(int c,int co,int p)
        {
            int num = (c*2)+(co*4)+(p*4);
            return num;

        }

        //***************Q6*****************
        static string state(string username , string password)
        {
            bool f = true;
            string[] name = { "lujain", "Ahmad", "Noor", "Mohammad", "lujain" };
            string[] pass = { "1234", "1596", "1564", "5632", "7852" };
            for(int a=0;a<5;a++)
            {
                if (username == name[a] && password == pass[a])
                {
                    f = true; break;
                }
                else f=false; 
            }

            if(f==true) { return "PASS USER"; }
           else { return "FAILD USER"; }

        }



        //*****************Q7***************
        static int power(int p)
        {
            return p*p;
        }
        //*****************Q8***************
        static void leap(int y)
        {
            if (((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0))
                Console.WriteLine(" is a Leap Year."+ y);
            else Console.WriteLine(" isn't a Leap Year."+ y);
        }

        //*****************Q9***************
        static string prime(int x)
        {   int f=0;
            //int f2 = x / 2;
            string pr;

            for(int i = 2; i <= (x-1); i++)
            {
                if (x == 2) f = 0;
                else {
                    if (x % i == 0) { f = 1;  break; }
                }
                
               
            }

            if ( f == 1)
            {
                pr = "Not Prime";
                return pr;
            }
            else
            {
                pr = "Prime";
                return pr;
            }
        
        }
        //*****************Q10***************
        static int lengthof(string s)
        {
            string[] sarr = s.Split();
            int n = sarr.Length;
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("********************Q1**************************");
            //Q1
            int[] numbers =new int[10] ;
            for(int a = 0; a < 10; a++)
            {
                Console.WriteLine("please enter number # "+(a+1));
                numbers[a]=Convert.ToInt32(Console.ReadLine());
            }
            sum(numbers);

            Console.WriteLine("********************Q2**************************");
            //Q2
            Console.WriteLine("Please indicate the number of times you would like to enter numbers.");
            int count=Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=count; i++)
            {
                Console.WriteLine("Please enter the # "+i+" number ");
                int x=Convert.ToInt32(Console.ReadLine());
                int cu = cube(x);
                Console.WriteLine("Number is : " + x+ " and cube of the "+x+ "  is :"+cu);
            }
            Console.WriteLine("********************Q3**************************");
            //Q3
            int[] year = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            Console.Write("the years > 1950 : ");
            arr(year);
            
            Console.WriteLine("********************Q4**************************");
            //Q4
            Console.WriteLine("please enter your age : ");
            int age=Convert.ToInt32(Console.ReadLine());
            int ageinday = ageiny(age);
            Console.WriteLine("the age in days : " + ageinday);

            Console.WriteLine("********************Q5**************************");
            //Q5
            Console.WriteLine("please enter the number of chickens you have : ");
            int chickens=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the number of cows  you have : ");
            int cows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the number of Pie you have : ");
            int Pie = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("the number of legs : "+animal(chickens, cows,Pie));

            Console.WriteLine("********************Q6**************************");
            //Q6
            //state
            Console.WriteLine("Please Enter Your UserName");
            string user=Console.ReadLine();
            Console.WriteLine("Please Enter Your Password");
            string pass = Console.ReadLine();
            string res= state(user,pass);
            Console.WriteLine("The User : "+res);

            Console.WriteLine("********************Q7**************************");
            //Q7
            Console.WriteLine("enter the number to show the power of this number");

            int po =Convert.ToInt32(Console.ReadLine());
            int po2 = power(po);
            Console.WriteLine("the power of " + po + " is " + po2);

            Console.WriteLine("********************Q8**************************");
            //Q8
            //if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) 
            //    Console.WriteLine("{0} is a Leap Year.", Year);
            Console.WriteLine("Please Enter Year from range 1900-2024 :  ");
            int Year = Convert.ToInt32(Console.ReadLine());
            leap(Year);


            Console.WriteLine("********************Q9**************************");
            //Q9
            Console.WriteLine("Please enter number to check if it prim number or not");

            int numb =Convert.ToInt32(Console.ReadLine());
            string pri = prime(numb);
            Console.WriteLine("The number is : " + pri);


            Console.WriteLine("********************Q10**************************");
            //Q10
            string sentence=Console.ReadLine();
            int coun = lengthof(sentence);
            Console.WriteLine("The Sentence : ' " + sentence + " '  And The Number Of Words is : " + coun);


        }
    }
}
