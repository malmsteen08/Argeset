using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

using System.Collections.Generic;
using System.Threading;

namespace BuildingASimpleWorkflow
{

    class Program
    {
        static void Main(string[] args)
        {
            ////create and cache the workflow definition
            //Activity workflow1 = new Workflow1();
            //WorkflowInvoker.Invoke(workflow1);

            //Console.WriteLine("Thx for playing");
            
            Console.WriteLine("** Welcome To The WF App **");

            //Get data from user, to pass the workflow.
            Console.WriteLine("Please enter the data to pass the workflow: ");
            string wfData = Console.ReadLine();

            //package up the data as a dictionary
            Dictionary<string, object> wfArgs = new Dictionary<string, object>();
            wfArgs.Add("MessageToShow", wfData);

            //used to inform primary thread to wait
            AutoResetEvent waitHandle = new AutoResetEvent(false);

            //Pass to the workflow 
            WorkflowApplication app = new WorkflowApplication(new Workflow1(), wfArgs);

            app.Completed = (completeArgs) =>
            {
                waitHandle.Set();
                Console.WriteLine("The Workflow is done!");
            };

            //start workflow
            app.Run();

            //wait until i am notified the workflow is done
            waitHandle.WaitOne();

            //pass to the workflow
            //Activity workflow1 = new Workflow1();
            //WorkflowInvoker.Invoke(workflow1, wfArgs);

            Console.WriteLine("Thx for playing");

            Console.ReadLine();
        }
    }
}
