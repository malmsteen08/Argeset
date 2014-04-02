using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayInitialization
{

    class Program
    {

        static void Main(string[] args)
        {
            
            var stringArray = new[] {"one", "two", "three"};
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            var boolArray = new[] 
                { true, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            var integerArray = new[] 
                { 1, 2, 3 };
            Console.WriteLine("integerArray has {0} elements", integerArray.Length);

            Console.ReadLine();

        }

    }

}
