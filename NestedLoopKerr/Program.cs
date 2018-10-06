using System;
using static System.Console;
	

namespace NestedLoopKerr
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            

            Console.ReadLine();
            
        }
    }
}
