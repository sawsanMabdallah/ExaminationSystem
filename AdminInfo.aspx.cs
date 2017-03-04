using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminInfo : System.Web.UI.Page
{
    ObjectDataSource obj = new ObjectDataSource();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int userID = (int)Session["UserId"];
        obj.TypeName = "BussniessLayerStudents";
        obj.InsertMethod = "InsertAdmin";
        obj.InsertParameters.Add("Admin_name", TextBox1.Text);
        obj.InsertParameters.Add("Admin_Phone", TextBox3.Text);
        obj.InsertParameters.Add("Admin_address", TextBox4.Text);
        obj.InsertParameters.Add("Admin_birthdate", TextBox2.Text);
        obj.InsertParameters.Add("User_id", userID.ToString());
        obj.Insert();
        string message = "Admin Information Inserted";
        ClientScript.RegisterStartupScript(GetType(), "alert", "alert('" + message + "');", true);
    }
}