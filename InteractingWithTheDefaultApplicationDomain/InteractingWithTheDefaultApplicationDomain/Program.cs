using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;

namespace InteractingWithTheDefaultApplicationDomain
{
    class Program
    {
        static void ListAllAssembliesInAppDomain()
        { 
            //get acces to the AppDomain for the current thread
            AppDomain defaulAD = AppDomain.CurrentDomain;

            //get all loaded assemblies in the default AppDomain
            //Assembly[] loadedAssemblies = defaulAD.GetAssemblies();
            //Console.WriteLine("** Here are the assemblies loaded in {0} **\n", defaulAD.FriendlyName);

            var loadedAssemblies = from a in defaulAD.GetAssemblies() orderby a.GetName().Name select a;

            Console.WriteLine("** Here are the Assemblies loaded in {0} **\n", defaulAD.FriendlyName);
            
            foreach (var a in loadedAssemblies)
            {
                Console.WriteLine("-> Name : {0}", a.GetName().Name);
                Console.WriteLine("-> Version : {0}", a.GetName().Version);
            }
        }

        private static void InitDAD()
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;
            defaultAD.AssemblyLoad += (o, s) =>
                {
                    Console.WriteLine("{0} has been loaded!", s.LoadedAssembly.GetName().Name);
                };
        }

        static void Main(string[] args)
        {
            Console.WriteLine("** Fun with the Default AppDomain **\n");
            DisplaDADStats();
            Console.ReadLine();
            ListAllAssembliesInAppDomain();
            Console.ReadLine();            
        }

        private static void DisplaDADStats()
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;

            Console.WriteLine("Name of this domain : {0}", defaultAD.FriendlyName);
            Console.WriteLine("ID of this domain : {0}", defaultAD.Id);
            Console.WriteLine("Is this a default Domain : {0}", defaultAD.IsDefaultAppDomain());
            Console.WriteLine("Base Directory of This Domain : {0}", defaultAD.BaseDirectory);
        }

    }
}
