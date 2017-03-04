using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    public static DataSet ExamDate()
    {
        str = "select distinct Date from St_Ex_Q";
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
    public static DataSet CorrectiveCourse(string Crs_id)
    {
        str = "select distinct st.St_Fname + ' ' + st.St_Lname fullname , c.Crs_name CourseName from St_Ins_Crs s,St_Ex_Q e, Exam x ,Student st, Course c where s.St_id = e.St_id  and x.Ex_id = e.Ex_id and c.Crs_id = s.Crs_id and s.St_id = st.St_id and grade< (x.Total_Garde / 2)and s.Crs_id=" + Crs_id;
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }
    public static DataSet CorrectiveDept(string Dept_id)
    {

        str= "select distinct st.St_Fname+' '+st.St_Lname fullname from St_Ins_Crs s,St_Ex_Q e, Exam x ,Student st, Instructor i where s.St_id = e.St_id  and x.Ex_id = e.Ex_id  and s.St_id = st.St_id and grade< (x.Total_Garde / 2) and i.Ins_id = s.Ins_id and i.Dept_id ="+Dept_id;
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
        str = "select s.St_Fname+' '+s.St_Lname as fullname,c.Crs_name,Grade from Student s,Course c,St_Ins_Crs st where s.St_id=st.St_id and c.Crs_id= st.Crs_id";
        ds = DataAccessLayer.RunSelect(str);
        return ds;
    }

    public static DataSet SpecificStudent(string St_id)
    {
       
        str = "select St_id,St_fname FirstName,St_Lname LastName,St_phone Phone,St_address Address,Dept_ID Department from Student where St_id=" + St_id;
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

    public static int InsertStudent(string St_id,string St_Fname,string St_Lname, string St_phone,string St_address,string Dept_id, string User_id)
    {
        
        str = "Insert_student";
        SqlParameter par3 = new SqlParameter("@User_id", User_id);
        if (User_id == "NULL")
        {
            par3.Value = DBNull.Value;
        }
        SqlParameter[] par =
        {
            new SqlParameter("@St_id",St_id),
            new SqlParameter("@St_Fname",St_Fname),
            new SqlParameter("@St_Lname",St_Lname),
            new SqlParameter("@St_phone",St_phone),
            new SqlParameter("@St_address",St_address),
            new SqlParameter("@Dept_id",Dept_id),
            par3
        };
        int affeceted = DataAccessLayer.RunDML(str, par);
        return affeceted;
    }

    public static int UpdateStudent(string St_id, string St_Fname, string St_Lname, string St_phone, string St_address, string Dept_id,string User_id)
    {
        
        str = "Update_student";
        SqlParameter par3 = new SqlParameter("@User_id", User_id);
        if (User_id == "NULL")
        {
            par3.Value = DBNull.Value;
        }
        SqlParameter[] par =
        {
            new SqlParameter("@St_id",St_id),
            new SqlParameter("@St_Fname",St_Fname),
            new SqlParameter("@St_Lname",St_Lname),
            new SqlParameter("@St_phone",St_phone),
            new SqlParameter("@St_address",St_address),
            new SqlParameter("@Dept_id",Dept_id),
            par3
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

    public static int GenerateExam(string Crs_name,String MCQ,string TF)
    {
        str = "GenerateExam";
        SqlParameter[] par =
        {
            new SqlParameter("@Crs_name",Crs_name),
            new SqlParameter("@MCQ",MCQ),
            new SqlParameter("@TF",TF),

        };
        int affeceted = DataAccessLayer.RunDML(str, par);
        return affeceted;

    }
    public static int InsertAdmin(string Admin_name,string Admin_birthdate,string Admin_phone,string Admin_Address,string User_id)
    {

        str = "Insert_Admin";
        SqlParameter[] par =
        {
            new SqlParameter("@Admin_name",Admin_name),
            new SqlParameter("@Admin_birthdate",Admin_birthdate),
            new SqlParameter("@Admin_phone",Admin_phone),
            new SqlParameter("@Admin_Address",Admin_Address),
            new SqlParameter("@User_id",User_id),

        };
        int affeceted = DataAccessLayer.RunDML(str, par);
        return affeceted;
    }
    public static int UpdateAdmin(string Admin_id,string Admin_name, string Admin_birthdate, string Admin_phone, string Admin_Address)
    {

        str = "Update_admin";
        SqlParameter[] par =
        {
            new SqlParameter("@Admin_id",Admin_id),
            new SqlParameter("@Admin_name",Admin_name),
            new SqlParameter("@Admin_birthdate",Admin_birthdate),
            new SqlParameter("@Admin_phone",Admin_phone),
            new SqlParameter("@Admin_Address",Admin_Address),
        };
        int affeceted = DataAccessLayer.RunDML(str, par);
        return affeceted;
    }

    //public static DataSet SelectAdminInfo(string User_name)
    //{
    //    str = "select Admin_name,Admin_phone,Admin_Address,Admin_birthdate from Admin a, Login l where a.User_id = l.User_id and l.Username = '" + User_name + "'";
    //    ds = DataAccessLayer.RunSelect(str);
    //    return ds;
    //}

}