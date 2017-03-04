using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetExamQuestionByExid : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ObjectDataSource obj;
        if (!IsPostBack)
        {
            obj = new ObjectDataSource();
            obj.TypeName = "ReportsBusinessLayer";
            obj.SelectMethod = "selectExamIds";
            obj.Select();
            DropDownList1.DataSource = obj;
            DropDownList1.DataTextField = "Ex_id";
            DropDownList1.DataValueField = "Ex_id";
            DropDownList1.DataBind();
        }
    }

    protected void Button1_GetAllstudent_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("QuestionByExIdReport.aspx");
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session.Add("Exam_id_forReport", DropDownList1.SelectedValue);
    }
}