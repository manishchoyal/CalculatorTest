using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.CoreLib
{
    public class SimpleCalculator : ISimpleCalculator
    {
        private readonly IDiagnostics _diagnostics;
        private int _total = 0;

        public SimpleCalculator(IDiagnostics diagnostics)
        {
            _diagnostics = diagnostics;
        }
        public int Add(int start, int amount)
        {
            var total = start + amount;
            _diagnostics.LogCalculatedTotal(MethodBase.GetCurrentMethod().Name, total.ToString());
            return total;
        }
        public int Subtract(int start, int amount)
        {
            _total = start - amount;
            _diagnostics.LogCalculatedTotal(MethodBase.GetCurrentMethod().Name, _total.ToString());
            return _total;
        }
        public int Divide(int start, int by)
        {
            _total = start / by;
            _diagnostics.LogCalculatedTotal(MethodBase.GetCurrentMethod().Name, _total.ToString());
            return _total;
        }
        public int Multiply(int start, int by)
        {
            _total = start * by;
            _diagnostics.LogCalculatedTotal(MethodBase.GetCurrentMethod().Name, _total.ToString());
            return _total;
        }
    }
}
