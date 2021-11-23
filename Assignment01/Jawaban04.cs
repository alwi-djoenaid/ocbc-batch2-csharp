using System;

namespace Assignment01
{
    class Nomor4
    {
        static void reverse()
        {
            string num;

            Console.Write("Enter a number: ");
            num = Console.ReadLine();
            Console.WriteLine($"Reversed Number : {reverseNumber(num)}");
        }

        public static string reverseNumber(string number){
            String str;
            str = number.ToString();

            char[] strArray = str.ToCharArray();
            Array.Reverse(strArray);
            
            return new String(strArray);
        }
    }
}
