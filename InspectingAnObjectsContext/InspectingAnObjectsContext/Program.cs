using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InspectingAnObjectsContext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Fun with objject context **\n");

            SportsCar sport = new SportsCar();
            Console.WriteLine();

            SportsCar sport2 = new SportsCar();
            Console.WriteLine();

            SportsCarsTS synchroSport = new SportsCarsTS();
            Console.ReadLine();
        }
    }
}
