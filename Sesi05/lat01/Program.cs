using System;

namespace lat01
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop();

            Console.Write("Masukkan nama laptop : ");
            laptop1.merk = Console.ReadLine();
            Console.Write("Masukkan kapasitas RAM dari laptop : ");
            laptop1.ram = int.Parse(Console.ReadLine());
            Console.Write("Masukkan kapasitas memori dari laptop : ");
            laptop1.memory = int.Parse(Console.ReadLine());

            Console.WriteLine("\nMerk laptop adalah {0}", laptop1.merk);
            Console.WriteLine("Memiliki kapasitas ram {0}", laptop1.ram);
            Console.WriteLine("Memiliki kapasitas memori {0}", laptop1.memory);
        }
    }
}
