using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EmailLoggerService : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Email Loglandı");
        }
    }
}
