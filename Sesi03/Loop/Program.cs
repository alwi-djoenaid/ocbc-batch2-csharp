using System;

namespace Loop
{
    class Logika678
    {
        static void Main(string[] args)
        {
            int a = 10;
            int j = 0;

            // For loop logika 6
            for(int i=a; i<20; i++){
                Console.WriteLine(i);
            }

            // While loop logika 7
            while(a < 20){
                Console.WriteLine(a++);
            }

            // Do-While loop logika 8
            do{
                Console.WriteLine("i = {0}", j);
                j++;
            }while(j < 5);
        }
    }
}
