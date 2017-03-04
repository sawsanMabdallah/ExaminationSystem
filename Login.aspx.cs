using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    string ConnStr = ConfigurationManager.ConnectionStrings["localsqlserver"].ConnectionString;
    string strqry, User, Password;
    int RowCount;
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        TextBox name = (TextBox)Login1.FindControl("UserName");
        TextBox pass = (TextBox)Login1.FindControl("Password");
        using (SqlConnection con = new SqlConnection(ConnStr))
        {
            strqry = "Select * from Login";
            using (SqlCommand cmd = new SqlCommand(strqry))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    RowCount = dt.Rows.Count;
                    for (int i = 0; i < RowCount; i++)
                    {

                        User = dt.Rows[i]["UserName"].ToString();
                        Password = dt.Rows[i]["Password"].ToString();

                        if (User == name.Text && Password == pass.Text)
                        {
                            Session["UserName"] = User;
                            if (dt.Rows[i]["Role"].ToString() == "Admin")
                                Response.Redirect("AdminProfile.aspx");
                            else if (dt.Rows[i]["Role"].ToString() == "Student")
                                Response.Redirect("HomeStudent.aspx");
                            else if (dt.Rows[i]["Role"].ToString() == "Instructor")
                                Response.Redirect("HomeInstructor.aspx");
                        }
                    }
                }
            }
        }
    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {

    }
}