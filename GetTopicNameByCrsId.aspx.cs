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

    }

    protected void Button1_GetAllstudent_Click(object sender, EventArgs e)
    {
        Session.Add("Crs_id_forReport",TextBox1_Crs_id.Text);
        Response.Redirect("TopicNameReport.aspx");
    }
}