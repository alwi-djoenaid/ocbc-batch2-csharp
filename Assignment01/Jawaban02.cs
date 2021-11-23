using System;

namespace Assignment01
{
    class Nomor2
    {
        static void buildTriangle()
        {
            int input;
            int num='1';      
            int i, j, k, m;

            Console.Write("Enter the range = ");
            input = int.Parse(Console.ReadLine());

            for(i=1; i<=input; i++)      
            {      
                for(j=input; j>=i; j--)
                {
                    Console.Write(" "); 
                }     
                     
                for(k=1 ;k<=i; k++) 
                {
                    Console.Write(k);
                }    

                num--;

                for(m=i - 1; m>=1; m--)
                {
                    Console.Write(m);
                }   
                
                Console.Write("\n");
            }
        }
    }
}
