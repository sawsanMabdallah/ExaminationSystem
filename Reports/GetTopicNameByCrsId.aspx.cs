using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetTopicNameByCrsId : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ObjectDataSource obj;
        if (!IsPostBack)
        {
            obj = new ObjectDataSource();
            obj.TypeName = "ReportsBusinessLayer";
            obj.SelectMethod = "selectAllCourses";
            obj.Select();
            DropDownList1.DataSource = obj;
            DropDownList1.DataTextField = "Crs_name";
            DropDownList1.DataValueField = "Crs_id";
            DropDownList1.DataBind();
        }
    }

    protected void Button1_GetAllstudent_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("TopicNameReport.aspx");
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session.Add("Crs_id_forReport", DropDownList1.SelectedValue);
    }
}