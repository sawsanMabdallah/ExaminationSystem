using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Students : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_insert_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            ObjectDataSource1.InsertParameters["St_id"].DefaultValue = TextBoxID.Text;
            ObjectDataSource1.InsertParameters["St_Fname"].DefaultValue = TextBoxFname.Text;
            ObjectDataSource1.InsertParameters["St_Lname"].DefaultValue = TextBoxLname.Text;
            ObjectDataSource1.InsertParameters["St_phone"].DefaultValue = TextBoxPhone.Text;
            ObjectDataSource1.InsertParameters["St_address"].DefaultValue = TextBoxAddress.Text;
            ObjectDataSource1.InsertParameters["Dept_id"].DefaultValue = DropDownListDept.SelectedValue;
            ObjectDataSource1.Insert();
        }
    }
}