using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Reflection;

namespace UnderstandingLateBindings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Fun With Late Binding **");

            Assembly a = null;

            try
            {
                a = Assembly.Load("CarLibrary");
            }
            catch(FileNotFoundException ex) 
            {
                Console.WriteLine(ex.Message);
                return;
            }

            if (a != null)
                CreateUsingLateBinding(a);
            Console.ReadLine();
        }

        private static void CreateUsingLateBinding(Assembly asm)
        {
            try
            {
                //get metadata for thr minivan type
                Type miniVan = asm.GetType("CarLibrary.MiniVan");

                //create the minivan on the fly
                object obj = Activator.CreateInstance(miniVan);
                Console.WriteLine("Created a {0} using late binding!", obj);
                //get info for TurboBoost
                MethodInfo mi = miniVan.GetMethod("TurboBoost");

                //Invoke method ('null' for no paramethers)
                mi.Invoke(obj, null);                    
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
