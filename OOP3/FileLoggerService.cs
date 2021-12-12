using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class FileLoggerService : ILogger
    {
        public void Log()
        {
            Console.WriteLine("File Loglandı");
        }
    }
}
