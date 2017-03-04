using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetStudentsperDepartment : System.Web.UI.Page
{
    ObjectDataSource obj;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            obj = new ObjectDataSource();
            obj.TypeName = "ReportsBusinessLayer";
            obj.SelectMethod = "selectAllDepartments";
            obj.Select();
            DropDownList1.DataSource = obj;
            DropDownList1.DataTextField = "Dept_name";
            DropDownList1.DataValueField = "Dept_id";
            DropDownList1.DataBind();
        }
    }

    protected void Button1_GetAllstudent_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("StudentInfoPerDepartReport.aspx");
    }




    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session.Add("Dept_id_forReport", DropDownList1.SelectedValue);
    }
}
