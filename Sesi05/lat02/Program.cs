using System;

namespace lat02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            pesawat.setNama = "Garuda";
            pesawat.setKetinggian = "2500ft";

            pesawat.terbang();
            pesawat.sudahTerbang();
            Console.Read();
        }
    }
}
