using System;

namespace lat03
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            PesawatTempur pesawatTempur = new PesawatTempur();

            pesawat.setName = "Boeing 737";
            pesawat.setKetinggian = "2500ft";
            pesawat.setJumlahRoda = 12;
            pesawat.setJumlahPenumpang = 200;

            pesawatTempur.setName = "F14";
            pesawatTempur.setKetinggian = "3500ft";
            pesawatTempur.setJumlahRoda = 4;
            pesawatTempur.setJumlahPenumpang = 1;

            pesawat.terbang();
            pesawatTempur.terbang();

            pesawat.terbangTinggi();
            pesawatTempur.terbangTinggi();
        }
    }
}
