using Microsoft.Data.SqlClient;
using System.Data;

namespace Assessment2.Misc
{
    public class EmployeeDB
    {
        public static DataSet GetEmployee()
        {
            SqlConnection sqlConn = Misc.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand sqlComm = new SqlCommand("SP_GetEmployee", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            da.SelectCommand = sqlComm;
            DataSet ds = new DataSet();

            sqlConn.Open();
            da.Fill(ds);

          
            sqlConn.Close();

            return ds;
        }
    }
}
