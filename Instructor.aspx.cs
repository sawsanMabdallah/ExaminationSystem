using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Instructor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        if (IsValid)
        {
            ObjectDataSource1.InsertParameters["Ins_id"].DefaultValue = txtins_id.Text;
            ObjectDataSource1.InsertParameters["Ins_name"].DefaultValue = txtins_name.Text;
            ObjectDataSource1.InsertParameters["Dept_id"].DefaultValue = Dropdept_id.SelectedValue;
            ObjectDataSource1.Insert();
        }
    }
}