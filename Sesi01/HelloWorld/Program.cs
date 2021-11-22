using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "";
            int val1;
            int val2;

            bool notEmpty = name.Length > 0;

            Console.WriteLine("Isenkkk luas kotaqq");
            Console.Write("Name : ");
            name = Console.ReadLine();
            Console.Write("Panjang : ");
            val1 = int.Parse(Console.ReadLine());
            Console.Write("Lebar : ");
            val2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Empty name : {notEmpty}");
            Console.WriteLine("Luasnya adalah " + (val1 * val2));
        }
    }
}
