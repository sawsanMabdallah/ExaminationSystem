using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
//using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataAccessLayer
/// </summary>
public class DataAccessLayer
{
    static SqlCommand com;
    static SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = AdvSQL; Integrated Security = True");



    public static DataSet RunSelect(string str)
    {
        com = new SqlCommand();
        com.CommandText = str;
        com.Connection = con;
        DataSet ds = new DataSet();
        SqlDataAdapter adapt = new SqlDataAdapter();
        adapt.SelectCommand = com;
        adapt.Fill(ds);
        return ds;
    }

    public static int RunDML(string str, SqlParameter[] par)
    {
        com = new SqlCommand();
        com.CommandType = CommandType.StoredProcedure;
        com.CommandText = str;
        com.Parameters.Clear();
        com.Parameters.AddRange(par);
        com.Connection = con;
        con.Open();
        int affected = com.ExecuteNonQuery();
        con.Close();
        return affected;
    }
}