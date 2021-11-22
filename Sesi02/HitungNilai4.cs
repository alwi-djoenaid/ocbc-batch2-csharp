using System;

// Belajar Boolean
namespace Sesi02
{
    class HitungNilai4
    {
        static void Main(string[] args)
        {
            int age;
            String pwd;
            
            Console.Write("Enter your age : ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter Password : ");
            pwd = Console.ReadLine();

            bool isAdult = age > 18;
            bool pwdIsCorrect = pwd == "OCBC";
              
            if(isAdult && pwdIsCorrect)
            {
              Console.WriteLine("Welcome to the club");
            } else {
              Console.WriteLine("Sorry, try again!");
            }
        }
    }
}
