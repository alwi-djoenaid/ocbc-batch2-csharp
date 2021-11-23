using System;

namespace Sesi04
{
    class ArrayLength
    {
        public static void Main(string[] args){
            int[] angka = new int[10];

            Console.WriteLine("Panjang array angka adalah" + angka.Length);

            Console.Write("Berikut adalah array angka: ");
            for(int i=0; i<angka.Length; i++){
                angka[i] = i * i;
                Console.Write(angka[i] + " ");
            }

            Console.WriteLine();

            int[, ,] angka1 = new int[10, 5, 6];
            Console.WriteLine("Panjang array angka1 adalah " + angka1.Length);
        }
    }
}
