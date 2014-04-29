using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildingQueryExpressionWithQueryOperators
{
    class Program
    {

        static void QueryStringWithOperators()
        {
            Console.WriteLine("** Using query Operators **");

            string[] currentVideoGames = { "Morrowind" , "Uncharted 2" , "Fallout 3" , "Daxter", "System shock 2"};

            var subset = from game in currentVideoGames
                         where game.Contains(" ")
                         orderby game
                         select game;

            foreach (string s in subset)
                Console.WriteLine("Item : {0}", s);
        }

        static void QueryStringsWithEnumerableLambdas()
        {
            Console.WriteLine("** Using Enumerable / Lambda Expressions **");

            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System shock 2" };

            var subset = currentVideoGames.Where(game => game.Contains(" ")).OrderBy(game => game).Select(game => game);

            foreach (var game in subset)
                Console.WriteLine("Item : {0}", game);
            Console.WriteLine();
        }

        static void QueryStringsWithAnonymousMethods()
        {
            Console.WriteLine("** Usşng Anonymous Nethods **");

            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System shock 2" };

            Func<string, bool> searchFilter = delegate(string game) { return game.Contains(" "); };
            Func<string, string> itemToProcess = delegate(string s) { return s; };

            var subset = currentVideoGames.Where(searchFilter)
                .OrderBy(itemToProcess).Select(itemToProcess);

            foreach (var game in subset)
                Console.WriteLine("Item : {0}", game);
            Console.WriteLine();
        }



        static void Main(string[] args)
        {

        }
    }
}
