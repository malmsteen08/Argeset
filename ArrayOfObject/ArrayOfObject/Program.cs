using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayOfObject
{

    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Array Of Object");

            //var objectArray = new[]
            object[] objectArray = new object[]
                {10, false, new DateTime(01,02,1951), "Form & Void"};

            foreach (object obj in objectArray)
            {

                Console.WriteLine("Type : {0}, Value : {1}", obj.GetType(), obj);
            
            }

            Console.ReadLine();

        }

    }

}
