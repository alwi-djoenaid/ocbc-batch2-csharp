using System;

// Belajar data type & operator
namespace Sesi02
{
    class Project01
    {
        static void Main(string[] args)
        {
            int len = 20;
            double wid = 2.3;

            Console.WriteLine("Area calculation");
            Console.WriteLine("Area : Length * Width");
            Console.WriteLine($"Area : {len} * {wid}");
            Console.WriteLine($"Area : {len * wid}");
        }
    }
}
