using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CalculatorTest.DataAccessLayer
{
    public class AdoNetManager : IDatabaseManager
    {
        //This should be placed in a seperated constants file.
        private const string InsertStoredProcedureName = "InsertCalculatedVaue";
        public void SaveCalculatedValue(string functionName, string total)
        {
            ExecuteNonQueryCommandAgainstDatabase(functionName, total);
        }

        private void ExecuteNonQueryCommandAgainstDatabase(string functionName, string total)
        {
            SqlParameter[] inputParams = new SqlParameter[2];
            inputParams[0] = new SqlParameter("@functionName", functionName);
            inputParams[1] = new SqlParameter("@functionTotal", total);

            try
            {               
                using (SqlConnection con = new SqlConnection(GetConnection()))
                {
                    using (SqlCommand cmd = new SqlCommand(InsertStoredProcedureName, con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("@functionName", SqlDbType.VarChar).Value = functionName;
                        cmd.Parameters.Add("@functionTotal", SqlDbType.VarChar).Value = total;

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        public static string GetConnection()
        {
            return ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;           
        }
    }
}
