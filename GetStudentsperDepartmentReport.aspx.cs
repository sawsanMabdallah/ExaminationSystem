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
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }

    protected void Button1_GetAllstudent_Click(object sender, EventArgs e)
    {
        Session.Add("Dept_id_forReport", TextBox1_Deptno.Text);
        Response.Redirect("StudentInfoPerDepartReport.aspx");
    }
     


}
