﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace practiceProblems2
{
    public class construction  
    {
        string firefox = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
        string link1 = @"https://www.youtube.com/watch?v=hl_9_q_uLF8";
        string link2 = @"https://youtu.be/JwXohnAYyuc?t=22s";


        public void openFirefox(string url)
        {
            ProcessStartInfo ffStart = new ProcessStartInfo();
            ffStart.FileName = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            ffStart.Arguments = url;
            ffStart.UseShellExecute = false;
            Process.Start(ffStart);             
        }
        public construction()
        {
            openFirefox(link1);
            Console.WriteLine("constructor");
            Console.ReadKey();     
        }
        ~construction()
        {
            Console.WriteLine("destructor");
            openFirefox(link2);
        }
    }
}                    