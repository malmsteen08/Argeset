using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Diagnostics;

namespace EnumeratingRunnigProcess
{
    class Program
    {
        static void ListAllRunningProcess()
        {
            var runningProcess = from proc in Process.GetProcesses(".") orderby proc.Id select proc;

            foreach (var p in runningProcess)
            {
                string info = string.Format("-> PID : {0}\t name : {1}", p.Id, p.ProcessName);
                Console.WriteLine(info);
            }
            Console.WriteLine("*******************");
        }

        static void EnumThreadsForPid(int pID)
        {
            Process theProc = null;

            try
            {
                theProc = Process.GetProcessById(pID);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine("Here are the threads used by: {0}", theProc.ProcessName);
            ProcessThreadCollection theTreads = theProc.Threads;
            ProcessModuleCollection theMods = theProc.Modules;

            foreach (ProcessThread pt in theTreads)
            {
                string info = string.Format("-> Thread ID:{0}\tStart Time: {1}\tProperty: {2}",pt.Id, pt.StartTime.ToShortTimeString(), pt.PriorityLevel);
                Console.WriteLine(info);
            }

            foreach (ProcessModule pm in theMods)
            {
                string info = string.Format("ModName : {0}", pm.ModuleName);
                Console.WriteLine(info);
            }
            Console.WriteLine("************************");
        }

        static void StartAndKillProcess()
        {
            Process ieProc = null;

            try
            {
                ieProc = Process.Start("IExplorer.exe", "www.google.com");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-->Hit Enter To Kill {0}", ieProc.ProcessName);
            Console.ReadLine();

            try
            {
                ieProc.Kill();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("** Fun With Processes **\n");
            ListAllRunningProcess();
            Console.ReadLine();

            Console.WriteLine("** Enter PID Process To Investigate **");
            Console.WriteLine("PID: ");
            string pID = Console.ReadLine();
            int theProcID = int.Parse(pID);

            EnumThreadsForPid(theProcID);
            Console.ReadLine();
        }
    }
}
