using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentInfoaspx : System.Web.UI.Page
{
    ObjectDataSource obj;
    protected void Page_Load(object sender, EventArgs e)
    {
        obj = new ObjectDataSource();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int userID =(int) Session["UserId"];
        obj.TypeName = "BussniessLayerStudents";
        obj.InsertMethod = "InsertStudent";
        obj.InsertParameters.Add("St_id", "22");
        obj.InsertParameters.Add("St_Fname", TextBox1.Text);
        obj.InsertParameters.Add("St_Lname", TextBox2.Text);
        obj.InsertParameters.Add("St_phone", TextBox3.Text);
        obj.InsertParameters.Add("St_Address", TextBox4.Text);
        obj.InsertParameters.Add("dept_id", DropDownList1.SelectedValue);
        obj.InsertParameters.Add("User_id", userID.ToString());
        obj.Insert();
    }
}