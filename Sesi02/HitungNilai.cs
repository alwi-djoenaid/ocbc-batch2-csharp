using System;

// Belajar Boolean
namespace Sesi02
{
    class HitungNilai
    {
        static void Main(string[] args)
        {
            int pertama, kedua, ketiga, total;
            double avg;
            
            Console.WriteLine("=== Perhitungan Nilai ===");
            Console.Write("Masukkan Nilai Pertama : ");
            pertama = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Nilai kedua : ");
            kedua = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Nilai ketiga : ");
            ketiga = int.Parse(Console.ReadLine());

            total = pertama + kedua + ketiga;
            avg = total / 3.0;

            Console.WriteLine($"Total nilai adalah {total}");
            Console.WriteLine($"Rata-rata nilai adalah {avg}");
            Console.Read();
        }
    }
}
