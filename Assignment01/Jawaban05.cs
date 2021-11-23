using System;

namespace Assignment01
{
    class Program
    {
        static void convertToLetter()
        {
            string num;
            string str = "";

            Console.Write("Enter the Number : ");
            num = Console.ReadLine();

            for(int i=0; i<num.Length; i++){
                if(num[i].Equals('1')){
                    str += "one ";
                }
                else if(num[i].Equals('2')){
                    Console.WriteLine(num[i]);
                    str += "two ";
                }
                else if(num[i].Equals('3')){
                    str += "three ";
                }
                else if(num[i].Equals('4')){
                    str += "four ";
                }
                else if(num[i].Equals('5')){
                    str += "five ";
                }
                else if(num[i].Equals('6')){
                    str += "six ";
                }
                else if(num[i].Equals('7')){
                    str += "seven ";
                }
                else if(num[i].Equals('8')){
                    str += "eight ";
                }
                else if(num[i].Equals('9')){
                    str += "nine ";
                }
                else if(num[i].Equals('0')){
                    str += "zero ";
                }
            }

            Console.WriteLine(str);
        }
    }
}
