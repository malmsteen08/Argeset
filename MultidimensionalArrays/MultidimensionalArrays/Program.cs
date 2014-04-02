using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultidimensionalArrays
{

    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Rectangular Multidimensional Array.");

            //var myMatrix = new[6, 6];
            int[,] myMatrix;
            myMatrix = new int[6, 6];

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    myMatrix [i, j] = i * j;

            
            for(int i = 0 ; i < 6 ; i++)
            {
                for(int j = 0 ; j < 6 ; j++ )
                    Console.Write(myMatrix[i , j] + "\t");
                Console.WriteLine();
            }

        JeggedMultidimensionalArray();
        PassAndReceiveArrays();

        Console.WriteLine();
        Console.ReadLine();
        
        }

        private static void PassAndReceiveArrays()
        {
            Console.WriteLine("Array as params and return values");

            var ages = new[]  { 20, 22, 24, 0 };
            PrintArray(ages);

            string[] strs = GetStringArray();
            foreach (string s in strs)
                Console.WriteLine(s);
            
            Console.WriteLine();
        }

        private static string[] GetStringArray()
        {
            var theString = new[] { "Hello", "from", "GetStringArray" };
            return theString;
        }

        private static void PrintArray(int[] ages)
        {
            for (int i = 0; i < ages.Length; i++)
                Console.WriteLine("Item {0} is {1} ", i, ages[i]);
        }

        private static void JeggedMultidimensionalArray()
        {

            Console.WriteLine("Jagged Multidimensional Array");

            //var myJaggerArray = new[5][];
            int[][] myJaggerArray = new int[5][];

            for(int i = 0 ; i< myJaggerArray.Length; i++)
                myJaggerArray[i] = new int[i + 7];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJaggerArray.Length; j++)
                    Console.Write(myJaggerArray[i][j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine();
        
        }

    }

}
