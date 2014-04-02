using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemArrayFunctionality
{

    class Program
    {

        static void Main(string[] args)
        {
            SystemArrayFunct();
        }

        private static void SystemArrayFunct()
        {
            Console.WriteLine("Working with System.Array.");

            var gothicBands = new[] { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

            Console.WriteLine("Here is the array: ");

            for (int i = 0; i < gothicBands.Length; i++)
            {
             
                Console.Write(gothicBands[i] + ", ");
            
            }
            Console.WriteLine("\n");

            //Array.Revers
            Array.Reverse(gothicBands);
            Console.WriteLine("Reversed Array");
            Console.WriteLine(gothicBands);

            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Cleared out all but one");
            
            Array.Clear(gothicBands, 1, 2);

            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
        
            Console.WriteLine("\n");
        Console.ReadLine();
        
        }
    
    }

}
