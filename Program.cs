using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Delcare Variable
            int num1;
            int num2 = 23;
            // assigning a value
            num1 = 13;
            int sum = num1 + num2;
            //concatination
            Console.WriteLine("num is " + num1);
            Console.WriteLine("Num1(" + num1 + ") plus num2(" + num2 + ") is " + sum);


            //ints
            int num3, num4, num5;
            num3 = 2;
            num4 = 3;
            num5 = 4;

            int sum2 = num3 + num4 + num5;

            Console.WriteLine("{0} + {1} + {2} = {3}", num3, num4, num5, sum2);

            //floats

            float f1 = 3.1415f;

            float f2 = 5.1f;

            float fDiv = f1 / f2;

            Console.WriteLine("{0} / {1} = {2}", f1, f2, fDiv);

            //doubles

            double d1 = 3.1415;

            double d2 = 5.1;

            double dDiv = d1 / d2;

            Console.WriteLine("{0} / {1} = {2}", d1, d2, dDiv);
  
            //decimal

            decimal dd1 = 3.1415M;

            decimal dd2 = 5.1M;

            decimal ddDiv = dd1 / dd2;

            Console.WriteLine("{0} / {1} = {2}", dd1, dd2, ddDiv);



        }
    }
}