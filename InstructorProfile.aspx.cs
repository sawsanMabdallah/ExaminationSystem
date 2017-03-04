using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InstructorInfo : System.Web.UI.Page
{
    ObjectDataSource obj = new ObjectDataSource();
    string Con = ConfigurationManager.ConnectionStrings["localsqlserver"].ConnectionString;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        string user = (string)Session["UserName"];
        string str = "select * from instructor a, Login l where a.User_id = l.User_id and l.Username='" + user + "'";
        SqlCommand cmd = new SqlCommand(str);
        SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, Con);
        dt = new DataTable();
        da.Fill(dt);
        TextBox1.Text = dt.Rows[0]["Ins_name"].ToString();
        DropDownList1.SelectedValue = dt.Rows[0]["Dept_id"].ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int ID = int.Parse(dt.Rows[0]["Ins_id"].ToString());
        if (IsValid)
        {
            obj.TypeName = "BussniessLayerInstructor";
            obj.UpdateMethod = "UpdateInstructor";
            obj.UpdateParameters.Clear();
            obj.UpdateParameters.Add("Ins_id", ID.ToString());
            obj.UpdateParameters.Add("Ins_name", TextBox1.Text);
            obj.UpdateParameters.Add("Dept_id", DropDownList1.SelectedValue);
            obj.Update();
        }
    }
}