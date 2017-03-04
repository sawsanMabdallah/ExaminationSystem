using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataAccessLayer
/// </summary>
public class DataAccessLayer
{
    static SqlCommand com;
    static SqlConnection con = new SqlConnection("Data Source =DESKTOP-A4PGC7O\\MSSQLSERVER_EMAN; Initial Catalog = AdvSQL; Integrated Security = True");



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
    //public static DataSet GetStdInfoPerDepart(string str,params SqlParameter[] par)
    //{
    //    com = new SqlCommand();
    //    com.CommandType = CommandType.StoredProcedure;
    //    com.CommandText = str;
    //    com.Parameters.Clear();
    //    com.Parameters.AddRange(par);
    //    com.Connection = con;
    //    con.Open();
    //    SqlDataAdapter adapt = new SqlDataAdapter();
    //    adapt.SelectCommand = com;
    //    Students dsStudents = new Students();
    //    adapt.Fill(dsStudents, "DataTable1");
    //    con.Close();
    //   return dsStudents;
    //}
}