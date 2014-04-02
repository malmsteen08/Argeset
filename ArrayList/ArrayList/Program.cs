using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayList
{

    class Program
    {

        static void Main(string[] args)
        {
           
            SimpleArrays();
            Console.ReadLine();
        
        }

        private static void SimpleArrays()
        {

            Console.WriteLine("Simple Array Creation.");

            var MyInts = new[3];
            MyInts[0] = 100;
            MyInts[1] = 200;
            MyInts[2] = 300;

            foreach (int i in MyInts)
            Console.WriteLine(i);
        
            Console.ReadLine();

        }

    }

}
