using CalculatorTest.Data;
using System;
using System.Collections.Generic;
using System.Text;


namespace CalculatorTest.DataAccessLayer
{
    public class EntityFrameworkManager : IDatabaseManager
    {
        public void SaveCalculatedValue(string functionName, string total)
        {
            // insert into database using EF
            using (var db = new CalculatorEntities())
            {
                db.SimpleCalculatorResults.Add(
                    new SimpleCalculatorResult
                    {
                        FunctionName = functionName,
                        FunctionTotal = total,
                        CreatedOn = DateTime.Now
                    });

                db.SaveChanges();
            }
        }
    }
}
