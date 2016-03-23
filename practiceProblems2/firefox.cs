using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace practiceProblems2
{
    class firefox
    {
        public firefox(string url)
        {
            ProcessStartInfo ffStart = new ProcessStartInfo();
            ffStart.FileName = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            ffStart.Arguments = url;
            Process.Start(ffStart);
            GC.SuppressFinalize(ffStart);

        }
    }
}
