using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int j = 0;

            for(int i=a; i<20; i++){
                Console.WriteLine(i);
            }

            while(a < 20){
                Console.WriteLine(a++);
            }

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
