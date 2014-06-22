using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

using System.Collections.Generic;

namespace BuildingAFlowchartWorkflow
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<string, object> wfArgs = new Dictionary<string, object>();
                wfArgs.Add("UserName", "Mel");
                Activity workflow1 = new Workflow1();
                WorkflowInvoker.Invoke(workflow1, wfArgs);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Data["Reason"]);
            }
        }

        private static void ExecuteBusinessProcess()
        {
            string UserName = "Andrew";
            Console.WriteLine("Hello {0}", UserName);
            Console.WriteLine("Do You Want me to list all machine drives?");

            string YesOrNo = Console.ReadLine();
            if (YesOrNo.ToUpper() == "Y")
            {
                Console.WriteLine("Wonderfull");
                string[] DriveNames = Environment.GetLogicalDrives();
                foreach (string item in DriveNames)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Thx for using this workflow");
            }
            else
            {
                Console.WriteLine("K, Bye...");
                Exception ex = new Exception("User Said No");
                ex.Data["Reason"] = "YesOrNo was false";
            }
        }
    }
}
