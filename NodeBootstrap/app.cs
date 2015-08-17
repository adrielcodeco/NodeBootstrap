using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NodeBootstrap
{
    public class app
    {
        [STAThread]
        static void Main()
        {
            var args = Environment.GetCommandLineArgs().Length > 1 ? String.Join(" ", Environment.GetCommandLineArgs(), 1, Environment.GetCommandLineArgs().Length - 1) : "";

            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.FileName = "CMD";
            process.StartInfo.Arguments = "/c " + Properties.Settings.Default.AppCommand + " " + args;
            process.Start();
        }
    }
}
