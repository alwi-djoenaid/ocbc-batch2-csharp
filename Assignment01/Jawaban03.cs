using System;

namespace Assignment01
{
    class Nomor3
    {
        static void calculateFactorial()
        {
            int num;

            Console.Write("Enter any number : ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Factorial of {num} is : {factorial(num)}");
        }

        public static int factorial(int num){
            int result = num;

            for(int i=result - 1; i>0; i--){
                result *= i;
            }

            return result;
        }
    }
}
