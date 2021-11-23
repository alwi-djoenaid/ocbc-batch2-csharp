using System;

namespace Sesi04
{
    class MultiDimensionArray
    {
        public static void Main(string[] args){
            int t,i;
            int [,] tabel = new int[3,4];

            for(t=0; t<3; ++t){
                for(i=0; i<4; ++i){
                    tabel[t,i] = (t * 4) + i + 1;
                    Console.Write(tabel[t,i] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n");

            // Demo inisialisasi array multidimensi
            int [,]data = {
                {1, 1},
                {2, 4},
                {3, 9},
                {4, 16},
                {5, 25},
                {6, 36},
                {7, 49},
                {8, 64},
                {9, 81},
                {10, 100}
            };

            for(int k=0; k<10; k++){
                for(int m=0; m<2; m++){
                    Console.Write(data[k,m] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
