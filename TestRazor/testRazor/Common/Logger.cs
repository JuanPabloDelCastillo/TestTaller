﻿using System;
using System.IO;

namespace TestRazor.Common
{
    public static class Logger
    {
        public static void Log(string mensaje)
        {
            File.AppendAllText(@"C:\Users\Sabra-jca\Desktop\ArchivoLogs.txt",
                string.Format("{0} - INFO: {1}", DateTime.Now,
                mensaje + Environment.NewLine));
        }
    }
}