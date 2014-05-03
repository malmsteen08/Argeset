using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Remoting.Contexts;//For context type
using System.Threading; //for thread type

namespace InspectingAnObjectsContext
{
    class SportsCar
    {
        public SportsCar()
        {
            Context ctx = Thread.CurrentContext;
            Console.WriteLine("{0} object in context {1}", this.ToString(), ctx.ContextID);
            foreach (IContextProperty itfCtxProp in ctx.ContextProperties)
                Console.WriteLine("-> Ctx Prop : {0}", itfCtxProp.Name);
        }
    }

    [Synchronization]
    class SportsCarsTS : ContextBoundObject
    {
        public SportsCarsTS()
        {
            Context ctx = Thread.CurrentContext;
            Console.WriteLine("{0} object in context {1}", this.ToString(), ctx.ContextID);
            foreach (IContextProperty itfCtxProp in ctx.ContextProperties)
                Console.WriteLine("-> Ctx Prop : {0}", itfCtxProp.Name);
        }
    }
    
}
