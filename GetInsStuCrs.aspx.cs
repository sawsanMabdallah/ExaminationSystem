using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetInsStuCrs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_GetAllstudent_Click(object sender, EventArgs e)
    {
        Session.Add("Ins_id_forReport", TextBox1_Instructor_id.Text);
        Response.Redirect("InsStuCrsReport.aspx");
    }
}