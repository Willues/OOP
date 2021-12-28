using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab13
{
    class PPPLog
    {
        private static string fileName = @"D:\C#\lab13\lab13\PPPLogFile.txt";

        public static void ToFile(string message)
        {
            using (StreamWriter sr = new StreamWriter(fileName, true))
            {
                sr.WriteLine(message);
            }
        }
    }
}
