using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplyingLINQQueriestoPrimitiveArrays
{
    class Program
    {
        
        static void QueryOverString()
        {
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout", "Daxter", "System Shock 2" };

            IEnumerable<string> subset = from g in currentVideoGames//Dizideki ifadelerden arasında bosluk olan degerleri çağırdık!!!
                                             where g.Contains(" ") orderby g select g;

            foreach (string s in subset)
                Console.WriteLine("Item : {0}", s);
        }

        static void ReflectOverQueryResults(object resultSet)
        {
            Console.WriteLine("** Info About Your Query **");
            Console.WriteLine("resultSet is of type: {0}", resultSet.GetType().Name);
            Console.WriteLine("resultSet location: {0}", resultSet.GetType().Assembly.GetName().Name);
        }

        static void QueryOverInts()
        {
            int[] numbers = {10,20,30,1,2,3,8};

            //IEnumerable<int> subset = from i in numbers where i < 10 select i ;//dizide 10 dan küçük degerleri i ye ata
            var subset = from i in numbers 
                         where i < 10 
                         select i;//dizide 10 dan küçük degerleri i ye ata

            foreach (int i in subset)
                Console.WriteLine("{0} < 10", i);
                Console.WriteLine();

                numbers[0] = 4;// Change some data in the array

                foreach (int j in subset)
                    Console.WriteLine("{0} < 10", j);

                Console.WriteLine();
            ReflectOverQueryResults(subset);
        }

        static void ImmediateExecution()
        {
            int[] numbers = {10, 20, 30, 40, 1, 2, 3, 8};

            int[] subsetAsIntArray = (from i in numbers where i < 10 select i).ToArray();

            List<int> subsetAsListOfInts = (from i in numbers 
                                            where i < 10 
                                            select i).ToList<int>();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("**Fun With LINQ to Objects**\n");
            IEnumerable<string> subset = GetStringSubset();

            foreach (string item in subset)
            {
                Console.WriteLine(item);
            }

            foreach (string item in GetStringSubsetAsArray())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }

        static IEnumerable<string> GetStringSubset()
        {
            string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };

            IEnumerable<string> theRedColors = from c in colors 
                                               where c.Contains("Red") 
                                               select c;

            return theRedColors;
        }

        static string[] GetStringSubsetAsArray()
        {
            string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };

            var theRedColors = from c in colors
                               where c.Contains("Red")
                               select c;

            return theRedColors.ToArray();
        }

     }
}
