using System;

namespace IfElse
{
    class Logika3
    {
        static void Main(string[] args)
        {
            string name, pwd;

            Console.Write("Username : ");
            name = Console.ReadLine();
            Console.Write("Password : ");
            pwd = Console.ReadLine();

            bool nameIsCorrect = name == "ocbc";
            bool pwdIsCorrect = pwd == "bootcamp";

            if(nameIsCorrect && pwdIsCorrect)
            {
                Console.WriteLine("Anda berhasil login");
            } else {
                Console.WriteLine("Username atau Password anda salah");
            }
        }
    }
}
