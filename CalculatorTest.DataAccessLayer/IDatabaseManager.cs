using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorTest.DataAccessLayer
{
    public interface IDatabaseManager
    {
        void SaveCalculatedValue(string functionName, string total);
    }
}
