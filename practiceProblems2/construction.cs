using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace practiceProblems2
{
    public class construction  
    {
        string firefoxDirectory = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
        string firstVideo = @"https://www.youtube.com/watch?v=hl_9_q_uLF8";
        string secondVideo = @"https://youtu.be/JwXohnAYyuc?t=22s";


        public void launchFirefox(string url)
        {
            ProcessStartInfo openBrowser = new ProcessStartInfo();
            openBrowser.FileName = firefoxDirectory;
            openBrowser.Arguments = url;
            openBrowser.UseShellExecute = false;
            Process.Start(openBrowser);             
        }
        public construction()
        {
            Console.WriteLine("Press enter to open first video.");
            Console.ReadKey();
            launchFirefox(firstVideo);
            Console.WriteLine("Press enter to open second video.");
            Console.ReadKey();     
        }
        ~construction()
        {                           
            launchFirefox(secondVideo);     
        }
    }
}                    