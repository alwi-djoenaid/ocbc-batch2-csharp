using System;

namespace lat05
{
    class Program
    {
        protected int bil1, bil2;
        public void bilangan(int num1, int num2){
            bil1 = num1;
            bil2 = num2;
        }

        public virtual void penjumlahanPerkalianDll(){
            Console.WriteLine("=== Overriding 1 ===");
            Console.WriteLine($"Hasil penjumlahan angka {bil1} dan angka {bil2} = {bil1 + bil2}");
            Console.WriteLine($"Hasil perkalian angka {bil1} dan angka {bil2} = {bil1 * bil2}");
        }
    }

    class OverrideTest: Program{
        public override void penjumlahanPerkalianDll(){
            Console.WriteLine("=== Overriding 2 ===");
            Console.WriteLine($"Hasil pembagian angka {bil1} dan angka {bil2} = {bil1 / bil2}");
            Console.WriteLine($"Hasil pengurangan angka {bil1} dan angka {bil2} = {bil1 - bil2}");
        }

        static void Main(string[] args)
        {
            Program overrideTest = new Program();
            overrideTest.bilangan(10, 5);
            overrideTest.penjumlahanPerkalianDll();
            overrideTest = new OverrideTest();
            overrideTest.bilangan(20, 5);
            overrideTest.penjumlahanPerkalianDll();
            Console.Read();
        }
    }
}
