using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ReportsBusinessLayer
/// </summary>
public class ReportsBusinessLayer
{
   
    static DataSet ds = new DataSet();
    public static DataSet selectAllDepartments()
    {
        string str = "select [dbo].[Department].Dept_id,[dbo].[Department].Dept_name from [dbo].[Department]";

        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet selectAllExamIds()
    {
        string str = "select  distinct [dbo].[St_Ex_Q].Ex_id from [dbo].[St_Ex_Q]";

        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet selectAllstudentsIds()
    {
        string str = "select  distinct [dbo].[Student].St_id, [dbo].[Student].St_Fname+'  '+[dbo].[Student].St_Lname as StFullname from [dbo].[Student],[dbo].[St_Ex_Q] where[dbo].[Student].St_id =[dbo].[St_Ex_Q].St_id";

        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet selectExamIds()
    {
        string str = "select distinct  [dbo].[St_Ex_Q].Ex_id  from [dbo].[St_Ex_Q]";

        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet selectInstructorsName()
    {
        string str = "select [dbo].[Instructor].Ins_id,[dbo].[Instructor].Ins_name from [dbo].[Instructor]";

        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet selectAllCourses()
    {
        string str = "select [dbo].[Course].Crs_id,[dbo].[Course].Crs_name from [dbo].[Course]";

        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    //public static DataSet StudentDataPerDepart(int dept_id)
    //{
    //    Students std = new Students();
    //   DataSet st = new DataSet();
    //    SqlParameter par= new SqlParameter ("@Dept_id", SqlDbType.Int, 4);
    //    par.Value = dept_id;
    //    st = DataAccessLayer.GetStdInfoPerDepart("GetStudentInfo", par);
    //   // std = (Students)st;
    //    return st;
    //}      
}
