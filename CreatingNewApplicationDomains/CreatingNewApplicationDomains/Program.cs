using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace CreatingNewApplicationDomains
{
    class Program
    {

        //static void ListAllAssembliesInAppDomain(AppDomain defaultAD)
        //{
        //    var loadedAsssemblies = from a in defaultAD.GetAssemblies() orderby a.GetName().Name select a;

        //    Console.WriteLine("** Here are the assemblies loaded in {0} **", defaultAD.FriendlyName);

        //    foreach (var a in loadedAsssemblies)
        //    {
        //        Console.WriteLine("->Name : {0}", a.GetName().Name);
        //        Console.WriteLine("->Version : {0}", a.GetName().Version);
        //    }
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("** Fun With Costum AppDomains **\n");

            AppDomain defaultAD = AppDomain.CurrentDomain;
            defaultAD.ProcessExit += (o, s) =>
                {
                    Console.WriteLine("Default AD unloaded");
                };
            
            ListAllAssembliesInAppDomain(defaultAD);
            
            MakeNewAppDomain();
            Console.ReadLine();
        }

        private static void MakeNewAppDomain()
        {
            AppDomain newAD = AppDomain.CreateDomain("SecondAppDomain");
            //ListAllAssembliesInAppDomain(newAD);
            newAD.DomainUnload += (o, s) =>
                {
                    Console.WriteLine("The second AppDomain Has been unloaded!");
                };

            try
            {
                newAD.Load("CarLibrary");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            ListAllAssembliesInAppDomain(newAD);            
        }

        static void ListAllAssembliesInAppDomain(AppDomain ad)
        {
            var loadedAssemblies = from a in ad.GetAssemblies()
                                   orderby a.GetName().Name
                                   select a;
            Console.WriteLine("** Here are the assemblies loaded in {0} **", ad.FriendlyName);

            foreach (var a in loadedAssemblies)
            {
                Console.WriteLine("->Name : {0}", a.GetName().Name);
                Console.WriteLine("->Version: {0}", a.GetName().Version);
            }
        }

    }
}
