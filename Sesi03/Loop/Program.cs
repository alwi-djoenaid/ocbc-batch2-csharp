using System;

namespace Loop
{
    class Logika678
    {
        static void Main(string[] args)
        {
            int a = 10;
            int j = 0;

            // For loop
            for(int i=a; i<20; i++){
                Console.WriteLine(i);
            }

            // While loop
            while(a < 20){
                Console.WriteLine(a++);
            }

            // Do-While loop
            do{
                Console.WriteLine("i = {0}", j);
                j++;

                if(j > 5){
                    break;
                }
            }while(j < 10);
        }
    }
}
