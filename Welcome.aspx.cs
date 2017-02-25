using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Roles.IsUserInRole("Admin"))
        {
            Response.Redirect("HomeAdmin.aspx");
        }
        else if (Roles.IsUserInRole("Student"))
        {
            Response.Redirect("HomeStudent.aspx");
        }
        else if (Roles.IsUserInRole("Instructor"))
        {
            Response.Redirect("HomeInstructor.aspx");
        }
    }
}