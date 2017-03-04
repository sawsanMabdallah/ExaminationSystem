using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetStudentAnswersWithModelAnswers : System.Web.UI.Page
{
    ObjectDataSource obj;
    ObjectDataSource obj1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            obj = new ObjectDataSource();
            obj.TypeName = "ReportsBusinessLayer";
            obj.SelectMethod = "selectAllExamIds";
            obj.Select();
            DropDownList1.DataSource = obj;
            DropDownList1.DataTextField = "Ex_id";
            DropDownList1.DataValueField = "Ex_id";
            DropDownList1.DataBind();
            obj1 = new ObjectDataSource();
            obj1.TypeName = "ReportsBusinessLayer";
            obj1.SelectMethod = "selectAllstudentsIds";
            obj1.Select();
            DropDownList2.DataSource = obj1;
            DropDownList2.DataTextField = "StFullname";
            DropDownList2.DataValueField = "St_id";
            DropDownList2.DataBind();

        }
    }



    protected void Button1_GetAllstudent_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudentAnswersWithModelAnswersReport.aspx");
     
    }

    protected void TextBox1_Deptno_TextChanged(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session.Add("Exam_id_forReport", DropDownList1.SelectedValue);
      
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session.Add("Student_id_forReport", DropDownList2.SelectedValue);
    }
}