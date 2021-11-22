using System;

// Belajar Boolean
namespace Sesi02
{
    class Project03
    {
        static void Main(string[] args)
        {
            String name, address;
            int age;

            Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK ===");
            Console.Write("Masukkan nama : ");
            name = Console.ReadLine();
            Console.Write("Masukkan alamat : ");
            address = Console.ReadLine();
            Console.Write("Masukkan umur : ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Data telah tersimpan");
            Console.WriteLine();

            Console.WriteLine("Data berikut");
            Console.WriteLine($"Nama : {name}");
            Console.WriteLine($"Alamat : {address}");
            Console.WriteLine($"Umur: {age}");
            Console.WriteLine("Telah berhasil disimpan!");
        }
    }
}
