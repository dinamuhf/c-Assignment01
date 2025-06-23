using System;

namespace AssignmentSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + number);
            
            #endregion

            #region 2
            string input = "123abc";
            try
            {
                int result = Convert.ToInt32(input);
                Console.WriteLine("Converted number: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Cannot convert '123abc' to integer. FormatException occurred.");
            }
            Console.WriteLine();
            #endregion


            #region 3
            float a = 5.5f;
            float b = 2.2f;
            float floatResult = a + b;
            Console.WriteLine("Result: " + floatResult);
            #endregion 

            #region 4
            string text = "Hello World";
            string sub = text.Substring(6, 5);
            Console.WriteLine("Substring: " + sub);
            #endregion


            #region 5
            int x = 10;
            int y = x;
            y = 20;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            #endregion

            #region 6
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = arr1;
            arr2[0] = 100;
            Console.WriteLine("arr1[0] = " + arr1[0]);
            #endregion


            #region 7
            string first = "Hello";
            string second = "World";
            string combined = first + " " + second;
            Console.WriteLine("Combined: " + combined);
           
            #endregion

            #region 8
            int d;
            d = Convert.ToInt32(!(30 < 20));
            Console.WriteLine("Value of d: " + d);
            Console.WriteLine("Answer: A value 1 will be assigned to d.");
         

            #endregion

            #region 9
            Console.WriteLine(13 / 2 + " " + 13 % 2);
            Console.WriteLine("Answer: 6 1");
            Console.WriteLine();
            #endregion

            #region 10
            int num = 1, z = 5;

            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z); // Output: 7 7
            else
                Console.WriteLine(--num + z-- + " " + --z);
            Console.WriteLine("Answer: 7 7");

            #endregion
        }
    }
}

