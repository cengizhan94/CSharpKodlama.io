using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILogger
    {
        public DatabaseLoggerService()
        {

        }
        public void Log()
        {
            Console.WriteLine("Database Loglandı");
        }
    }
}
