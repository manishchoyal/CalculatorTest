using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.CoreLib
{
    public class LoggerIdentifier
    {
        public LoggingMode LogMode { get; set; }
    }

    public enum LoggingMode
    {
        Console,
        AdoNet,
        EntityFramework
    }
}
