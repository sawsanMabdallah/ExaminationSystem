using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BussinessLayerInstructor
/// </summary>
public class BussinessLayerInstructor
{
    static DataSet ds = new DataSet();
    public static DataSet selectInstructor()
    {
        string str;
        str = "select * from Instructor";
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static int UpdateInstructor(int Ins_id, string Ins_name, int Dept_id)
    {
        string str;
        str = "Update_instructor";
        SqlParameter[] par =
        {
            new SqlParameter("@Ins_id",Ins_id),
            new SqlParameter("@Ins_name",Ins_name),
            new SqlParameter("@Dept_id",Dept_id)
        };
        int affeceted = DataAccessLayer.RunDML(str, par);
        return affeceted;
    }
    public static int DeleteInstructor(int Ins_id, string Ins_name, int Dept_id)
    {
        string str;
        str = "Delete_instructor";
        SqlParameter[] par =
        {
            new SqlParameter("@Ins_id",Ins_id)
        };
        int affeceted = DataAccessLayer.RunDML(str, par);
        return affeceted;
    }
    public static int InsertInstructor(int Ins_id, string Ins_name, int Dept_id)
    {
        string str;
        str = "Insert_instructor";
        SqlParameter[] par =
        {
            new SqlParameter("@Ins_id",Ins_id),
            new SqlParameter("@Ins_name",Ins_name),
            new SqlParameter("@Dept_id",Dept_id)
        };
        int affeceted = DataAccessLayer.RunDML(str, par);
        return affeceted;
    }
    public static DataSet selectInst_percourse(int crs_id)
    {
        string str;
        str = "select distinct i.Ins_id,i.Ins_name from St_Ins_Crs s ,Instructor i where i.Ins_id = s.Ins_id and s.Crs_id ="+crs_id;
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet select_ins_cours()
    {
        string str;
        str = "select * from Course";
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet specific_stud_info(int st_id)
    {
        string str;
        str = "select * from student s where s.St_id = "+st_id;
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet select_students()
    {
        string str;
        str = "select * from student";
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet select_stud_grade()
    {
        string str;
        str = "select s.St_Fname+' '+s.St_Lname as fullname,c.Crs_name,Grade from Student s,Course c,St_Ins_Crs st where s.St_id=st.St_id and c.Crs_id= st.Crs_id";
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet StudentExamByID(string St_id)
    {
        string str;
        str = "select distinct  st.St_Fname+' '+st.St_Lname Fullname,S.St_id StudentID,s.Ex_id ExamID,C.Crs_name CourseName from St_Ex_Q S,Question Q, Course C,Student St where s.St_id = st.St_id  and Q.Q_id = S.Q_id and c.Crs_id = q.Crs_id and s.St_id=" + St_id;
        ds = DataAccessLayer.RunSelect(str);
        return ds;

    }
    public static DataSet select_questions_course(string crs_name)
    {
        string str;
        str = "select q.Q_body from Question q ,Course c where c.Crs_id = q.Crs_id and c.Crs_name ='"+crs_name+"'";
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
}