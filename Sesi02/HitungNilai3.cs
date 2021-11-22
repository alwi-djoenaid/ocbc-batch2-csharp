using System;

// Belajar Boolean
namespace Sesi02
{
    class HitungNilai3
    {
        static void Main(string[] args)
        {
            int val1;
            int val2;
            
            Console.Write("Jumlah Nilai 1 : ");
            val1 = int.Parse(Console.ReadLine());
            Console.Write("Jumlah Nilai 2 : ");
            val2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Hasil Perbandingan");
            Console.WriteLine($"Nilai 1 > Nilai 2 = {val1 > val2}");
            Console.WriteLine($"Nilai 1 >= Nilai 2 = {val1 >= val2}");
            Console.WriteLine($"Nilai 1 < Nilai 2 = {val1 < val2}");
            Console.WriteLine($"Nilai 1 <= Nilai 2 = {val1 <= val2}");
            Console.WriteLine($"Nilai 1 == Nilai 2 = {val1 == val2}");
            Console.WriteLine($"Nilai 1 !+ Nilai 2 = {val1 != val2}");
        }
    }
}
