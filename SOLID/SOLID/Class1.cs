using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface Ilogger
    {
        void LogMessage(string message);
    }
    public class FileLogger : Ilogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(@"Message from FileLogger");
        }
    }
    public class DBlogger : Ilogger
    {
        public void LogMessage(string message)
        {
           Console.WriteLine(@"Message from DB logger");
        }
    }

    public class LogFactory 
    { 
        public Ilogger _logger;
        public LogFactory (Ilogger logger)
        {
            _logger = logger;
        }
        public void LogMessageImplementor()
        {
            _logger.LogMessage("dumy");
        }
    }

    public class Test
    {
        public static void Main(String[] args)
        {
            var _logger = new LogFactory(new FileLogger());
            _logger.LogMessageImplementor();
        }
    }
}
