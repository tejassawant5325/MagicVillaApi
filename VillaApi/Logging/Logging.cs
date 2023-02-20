﻿using System.Security.Cryptography.X509Certificates;

namespace VillaApi.Logging
{
    public class Logging : ILogging
    {
        public void Log(string message, string type)
        {
            if (type == "error")
            {
                Console.Write("ERROR - " + message);
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
