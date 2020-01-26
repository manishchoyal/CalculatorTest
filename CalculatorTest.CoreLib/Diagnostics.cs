using CalculatorTest.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.CoreLib
{
    public class Diagnostics : IDiagnostics
    {
        private LoggingMode LogMode { get; set; }
        private readonly IDatabaseManager _databaseManager;
        public Diagnostics()
        {
            LogMode = LoggingMode.Console;
        }
        public Diagnostics(LoggingMode logMode, IDatabaseManager databaseManager)
        {
            LogMode = logMode;
            _databaseManager = databaseManager;
        }
        public void LogCalculatedTotal(string functionName, string total)
        {
            if (LogMode.Equals(LoggingMode.Console))
            {
                Console.WriteLine("Calculator function - {0} with result - {1}", functionName, total);
                Console.ReadLine();
            }
            else
            {
                _databaseManager.SaveCalculatedValue(functionName, total);
            }
        }
    }
}
