using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtocolRegiterApp
{
    static class Program
    {
        internal static string[] appParams;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            appParams = args;
            if(args.Length > 0)
            {
                var allArgs = string.Join(",", args); 
                if (args[0].ToLower().Trim().StartsWith("pamproto:rep"))
                {
                    Run(@"Pam.exe", allArgs);
                }
                else
                {
                    Run(@"pam.exe", allArgs);
                }
            }
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ProtocolRegiterApp());
        }
        private static void Run(string exeName, string arguments)
        {
            // Prepare the process to run
            ProcessStartInfo start = new ProcessStartInfo();
            // Enter in the command line arguments, everything you would enter after the executable name itself
            start.Arguments = arguments;
            // Enter the executable to run, including the complete path
            start.FileName = exeName;
            // Do you want to show a console window?
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = true;

            // Run the external process & wait for it to finish
            Process.Start(start);
            
        }
    }
}
