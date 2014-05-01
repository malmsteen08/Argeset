using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace BuildingACostumMetadataViewer
{
    class Program
    {

        static void ListMethods(Type t)
        {
            Console.WriteLine("** Methods **");
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
            {
                string retVal = m.ReturnType.FullName;
                string paramInfo = "( ";

                foreach (ParameterInfo pi in m.GetParameters())
                {
                    paramInfo += string.Format("{0} {1}", pi.ParameterType, pi.Name);
                }
                paramInfo += "( ";

                Console.WriteLine("->{0} {1} {2}", retVal, m.Name, paramInfo);
            }
            Console.WriteLine();
        }
                
        static void ListFields(Type t)
        {
            Console.WriteLine("** Fields **");
            var fieldNames = from f in t.GetFields() select f.Name;
            foreach (var name in fieldNames)
                Console.WriteLine("->{0}",name);
            Console.WriteLine();
        }

        static void ListProps(Type t)
        {
            var propNames = from p in t.GetProperties() select p.Name;
            foreach (var name in propNames)
                Console.WriteLine("->{0}", name);
            Console.WriteLine();
        }

        static void ListInterfaces(Type t)
        {
            Console.WriteLine("** Interfaces **");
            var ifaces = from i in t.GetInterfaces() select i;
            foreach (Type i in ifaces)
                Console.WriteLine("->{0}", i.Name);
        }

        static void ListVariousStats(Type t)
        {
            Console.WriteLine("** Various Statics **");
            Console.WriteLine("Base Class is : {0}", t.BaseType);
            Console.WriteLine("Is tyoe abstract : {0}", t.IsAbstract);
            Console.WriteLine("Is type sealed : {0}", t.IsSealed);
            Console.WriteLine("Is typr generic : {0}", t.IsGenericTypeDefinition);
            Console.WriteLine("Is type a class type= {0}", t.IsClass);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("** Welcome to MyTypeViewer **");
            string typeName = "";

            do{
                Console.WriteLine("\nEnter a type name to evaluate");
                Console.WriteLine("or enter Q to quit: ");

                typeName = Console.ReadLine();

                if (typeName.ToUpper() == "Q")
                {
                    break;
                }

                try{
                    Type t = Type.GetType(typeName);
                    Console.WriteLine("");
                    ListVariousStats(t);
                    ListFields(t);
                    ListProps(t);
                    ListMethods(t);
                    ListInterfaces(t);
                }
                catch{
                    Console.WriteLine("Sorry, cant find type");
                    }
                }while (true);
            }
       }

}

