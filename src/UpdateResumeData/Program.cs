using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateResumeData
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.SetCurrentDirectory(@"D:\home\site\wwwroot");
            var info = new ProcessStartInfo("cmd.exe", @" /c node .\\node_modules\\resume-cli\\index.js export index -f html --theme elegant") { UseShellExecute = false };
            var process = Process.Start(info);
            process.WaitForExit();
        }
    }
}
