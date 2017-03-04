using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BussniessLayerQuestion
/// </summary>
public class BussniessLayerQuestion
{
    static string str;
    static DataSet ds;
    public static DataSet SelectQuestion()
    {

        str = "select * from Question";
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet SelectCourse()
    {

        str = "select * from Course";
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static  DataSet SelectChoices(string Q_id)
    {
        str = "select * from Choices where Q_id=" + Q_id;
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }

    public static int UpdateQuestion(string Q_id,string Q_body,string Q_type,string Q_Answer,string Q_Grade,string Crs_id)
    {

        str = "Update_question";
        SqlParameter[] par =
        {
            new SqlParameter("@Q_id",1),
            new SqlParameter("@Q_body",Q_body),
            new SqlParameter("@Q_type",Q_type),
            new SqlParameter("@Q_Answer",Q_Answer),
            new SqlParameter("@Q_Grade",Q_Grade),
            new SqlParameter("@Crs_id",Crs_id),
            
        };
        int affeceted = DataAccessLayer.RunDML(str, par);
        return affeceted;
    }
    public static int InsertQuestion(int Q_id, string Q_body, string Q_type, string Q_Answer, string Q_Grade, string Crs_id)
    {

        str = "Insert_question";
        SqlParameter[] par =
        {
            new SqlParameter("@Q_id",Q_id),
            new SqlParameter("@Q_body",Q_body),
            new SqlParameter("@Q_type",Q_type),
            new SqlParameter("@Q_Answer",Q_Answer),
            new SqlParameter("@Q_Grade",Q_Grade),
            new SqlParameter("@Crs_id",Crs_id),

        };
        int affeceted = DataAccessLayer.RunDML(str, par);
        return affeceted;
    }
    public static int DeleteQuestion(string Q_id)
    {

        str = "Delete_question";
        SqlParameter[] par =
        {
            new SqlParameter("@Q_id",Q_id),
        };
        int affeceted = DataAccessLayer.RunDML(str, par);
        return affeceted;
    }

}