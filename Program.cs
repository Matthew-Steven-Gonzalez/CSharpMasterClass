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

            // strings

            string myname = "Matthew";

            string message = "My name is " + myname + ".";

            //string methods

            string capsMessage = message.ToUpper();
            string lowerMessage = message.ToLower();

            Console.WriteLine("My name is {0}.",myname);
            Console.WriteLine(message);
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerMessage);
            Console.ReadLine();


            //console methods 

            //Write

            Console.Write(message);

            //WriteLine

            Console.WriteLine(message);

            //ReadLine

            int stringValue = Console.Read();
            Console.WriteLine(stringValue);


            //implcit conversion
            int num = 123344353;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;


            //explicit conversion
            //cast double to int
            double mydouble = 32.42;
            int myInt;
            myInt = (int)mydouble;

            //type conversion

            string myString = myFloat.ToString();

            Console.WriteLine(myString);

            string myFirstString = "15";
            string mySecondString = "13";
            int num7 = int.Parse(myFirstString);
            int num8 = int.Parse(mySecondString);
            int intResult = num7 + num8;
            string result = myFirstString + mySecondString;

            Console.WriteLine(result);
            Console.WriteLine(intResult);

            //Assingment 1 

            string stringForFloat = "0.85";
            string stringForInt = "12345";

            int intValue = int.Parse(stringForInt);
            float floatValue = float.Parse(stringForFloat);

            Console.WriteLine(floatValue.GetType());
            Console.WriteLine(stringValue.GetType());
            Console.WriteLine(stringForFloat.GetType());
            Console.WriteLine(stringForInt.GetType());
        }
    }
}