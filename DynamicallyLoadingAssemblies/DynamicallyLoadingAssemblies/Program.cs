using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;
using System.IO;

namespace DynamicallyLoadingAssemblies
{
    class Program
    {

        static void DisplayTypesInAsm(Assembly asm)
        {
            Console.WriteLine("\n** Types in Assembly **");
            Console.WriteLine("->{0}", asm.FullName);
            Type[] types = asm.GetTypes();
            foreach (Type t in types)
                Console.WriteLine("Type : {0}", t);
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("** External Assembly Viewer **");

            string asmName = "";
            Assembly asm = null;

            do 
            {
                Console.WriteLine("\nEnter an assembly to evaluate");
                Console.WriteLine("or enter q to quit: ");

                //get name of assembly
                asmName = Console.ReadLine();

                //user want to quit?
                if(asmName.ToUpper() == "Q")
                {
                    break;
                }

                //try to load assembly
                try{
                    asm = Assembly.Load(asmName);
                    DisplayTypesInAsm(asm);
                }
                catch{
                    Console.WriteLine("Sorry, can't find assemby.");
                }
            }while (true);
        }
    }
}

