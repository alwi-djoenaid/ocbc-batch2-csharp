using System;

namespace IfElse
{
    class Logika2
    {
        static void Main(string[] args)
        {
            int nilai=75;

            if(nilai < 60){
                Console.WriteLine("Nilai kamu C");
            }
            else if(nilai < 80){
                Console.WriteLine("Nilai kamu B");
            } else {
                Console.WriteLine("Nilai kamu A");
            }
        }
    }
}
