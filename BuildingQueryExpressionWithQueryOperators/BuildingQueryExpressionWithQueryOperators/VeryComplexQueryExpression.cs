using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildingQueryExpressionWithQueryOperators
{
    class VeryComplexQueryExpression
    {
        public static void QueryStringsWithRawDelegates()
        {
            Console.WriteLine("** Using Raw  Delegates **");

            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System shock 2" };

            Func<string, bool> searchFilter = new Func<string, bool>(Filter);
            Func<string, string> itemToProcess = new Func<string, string>(ProcessItem);

            var subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);

            foreach (var game in subset)
                Console.WriteLine("Item : {0}", game);
            Console.WriteLine();
        }

        //delegate Target.
        public static bool Filter(string game) { return game.Contains(" "); }
        public static string ProcessItem(string game) { return game; }
    }
}
