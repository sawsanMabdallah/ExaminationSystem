using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BussniessLayer
/// </summary>
public class BussniessLayerStudents
{
    static string str;
    static DataSet ds;
    public static DataSet SelectStudent()
    {
       
        str = "select * from Student";
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet InsSalary()
    {

        str = "select Ins_name,Salary from Instructor";
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet StudentExam(string date)
    {
        str = "select distinct St_Fname+' '+St_Lname FullName,Ex_id ExamID  from Student S,St_Ex_Q SE where s.St_id=SE.St_id and date='" + date+"'";
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet SelectStudentName()
    {
        str="select St_Fname+' '+St_Lname Fullname,St_id from Student";
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet AllCourse()
    {
        str = "select * from Course";
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet QuestionPerCourse(string Crs_id)
    {
        str = "select  Q_body,Q_Grade,Q_Answer,MCQ from Question,Choices where Question.Q_id=Choices.Q_id and Crs_id=" + Crs_id;
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet StudentExamByID(string St_id)
    {
        str = "select distinct  st.St_Fname+' '+st.St_Lname Fullname,S.St_id StudentID,s.Ex_id ExamID,C.Crs_name CourseName from St_Ex_Q S,Question Q, Course C,Student St where s.St_id = st.St_id  and Q.Q_id = S.Q_id and c.Crs_id = q.Crs_id and s.St_id="+St_id;
        ds = DataAccessLayer.RunSelect(str);
        return ds;

    }
    public static DataSet StudentAnswer(string St_id)
    {
        str = "select St_Answers from St_Ex_Q where St_id=" + St_id;
        ds = DataAccessLayer.RunSelect(str);
        return ds;

    }
    public static DataSet StudentResult()
    {
        str = "select s.St_Fname+' '+s.St_Lname,c.Crs_name,Grade from Student s,Course c,St_Ins_Crs st where s.St_id=st.St_id and c.Crs_id= st.Crs_id";
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }

    public static DataSet SpecificStudent(string St_id)
    {
       
        str = "select * from Student where St_id=" + St_id;
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet DepartmentWithManager()
    {
      
        str = "select Department.Dept_id,Department.Dept_name,Ins_name from department,instructor where Manger_id=Ins_id";
         ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet SelectDepartment()
    {
       
        str = "select * from department";
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }

    public static int InsertStudent(string St_id,string St_Fname,string St_Lname, string St_phone,string St_address,string Dept_id)
    {
        
        str = "Insert_student";
        SqlParameter[] par =
        {
            new SqlParameter("@St_id",St_id),
            new SqlParameter("@St_Fname",St_Fname),
            new SqlParameter("@St_Lname",St_Lname),
            new SqlParameter("@St_phone",St_phone),
            new SqlParameter("@St_address",St_address),
            new SqlParameter("@Dept_id",Dept_id),
        };
        int affeceted = DataAccessLayer.RunDML(str, par);
        return affeceted;
    }

    public static int UpdateStudent(string St_id, string St_Fname, string St_Lname, string St_phone, string St_address, string Dept_id)
    {
        
        str = "Update_student";
        SqlParameter[] par =
        {
            new SqlParameter("@St_id",St_id),
            new SqlParameter("@St_Fname",St_Fname),
            new SqlParameter("@St_Lname",St_Lname),
            new SqlParameter("@St_phone",St_phone),
            new SqlParameter("@St_address",St_address),
            new SqlParameter("@Dept_id",Dept_id),
        };
        int affeceted = DataAccessLayer.RunDML(str, par);
        return affeceted;
    }

    public static int DeleteStudent(int St_id)
    {
        
        str = "Delete_student";
        SqlParameter[] par =
        {
            new SqlParameter("@St_id",St_id),
        };
        int affeceted = DataAccessLayer.RunDML(str, par);
        return affeceted;
    }


}