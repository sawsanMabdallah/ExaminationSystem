using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetStudentGradesInAllCourses : System.Web.UI.Page
{
    ObjectDataSource obj;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            obj = new ObjectDataSource();
            obj.TypeName = "ReportsBusinessLayer";
            obj.SelectMethod = "selectAllstudentsIds";
            obj.Select();
            DropDownList1.DataSource = obj;
            DropDownList1.DataTextField = "StFullname";
            DropDownList1.DataValueField = "St_id";
            DropDownList1.DataBind();
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session.Add("Student_id", DropDownList1.SelectedValue);

    }

    protected void Button1_GetAllstudent_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudentGradesReport.aspx");
    }
}