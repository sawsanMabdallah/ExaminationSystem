using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BussniessLayerDepartment
/// </summary>
public class BussniessLayerDepartment
{
    static DataSet ds = new DataSet();

    public static DataSet selectDepartment()
    {
        string str;
        str = "select * from Department";
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static int UpdateDepartment(int Dept_id,string Dept_name,int Manger_id)
    {
        string str;
        str = "Update_department";
        SqlParameter[] par =
        {
            new SqlParameter("@Dept_id",Dept_id),
            new SqlParameter("@Dept_name",Dept_name),
            new SqlParameter("@Manger_id",Manger_id)
        };
        int affeceted = DataAccessLayer.RunDML(str, par);
        return affeceted;
    }
    public static int InsertDepartment(int Dept_id, string Dept_name, int Manger_id)
    {
        string str;
        str = "Insert_department";
        SqlParameter[] par =
        {
            new SqlParameter("@Dept_id",Dept_id),
            new SqlParameter("@Dept_name",Dept_name),
            new SqlParameter("@Manger_id",Manger_id)
        };
        int affeceted = DataAccessLayer.RunDML(str, par);
        return affeceted;
    }
    public static int DeleteDepartment(int Dept_id)
    {
        string str;
        str = "Delete_department";
        SqlParameter[] par =
        {
            new SqlParameter("@Dept_id",Dept_id)
        };
        int affeceted = DataAccessLayer.RunDML(str, par);
        return affeceted;
    }
}
