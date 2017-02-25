using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegistrationForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void CreateUserWizard1_CreatedUser1(object sender, EventArgs e)
    {
        DropDownList roleDropDownList = (DropDownList)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("RoleDropDownList");
        Roles.AddUserToRole(CreateUserWizard1.UserName, roleDropDownList.SelectedValue);
    }
}