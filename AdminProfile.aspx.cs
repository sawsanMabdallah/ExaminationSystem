using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminProfile : System.Web.UI.Page
{
    ObjectDataSource obj = new ObjectDataSource();
    string Con = ConfigurationManager.ConnectionStrings["localsqlserver"].ConnectionString;
    DataTable dt;
   static string ID;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Panel4.Enabled = false;
            Button4.Enabled = false;
            Button3.Enabled = true;
            string user = (string)Session["UserName"];
            string str = "select * from Admin a, Login l where a.User_id = l.User_id and l.Username='" + user + "'";
            SqlCommand cmd = new SqlCommand(str);
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, Con);
            dt = new DataTable();
            da.Fill(dt);
            TextBox9.Text = dt.Rows[0]["Admin_name"].ToString();
            TextBox10.Text = dt.Rows[0]["Admin_birthdate"].ToString();
            TextBox11.Text = dt.Rows[0]["Admin_phone"].ToString();
            TextBox12.Text = dt.Rows[0]["Admin_Address"].ToString();
            ID = dt.Rows[0]["Admin_id"].ToString();
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel4.Enabled = true;
        Button4.Enabled = true;
        Button3.Enabled = false;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            string name=TextBox9.Text;
            string BD=TextBox10.Text;
            string phone=TextBox11.Text;
            string Addr=TextBox12.Text;
            obj.TypeName = "BussniessLayerStudents";
            obj.UpdateMethod = "UpdateAdmin";
            obj.UpdateParameters.Clear();
            obj.UpdateParameters.Add("Admin_id", ID);
            obj.UpdateParameters.Add("Admin_name", name);
            obj.UpdateParameters.Add("Admin_birthdate", BD);
            obj.UpdateParameters.Add("Admin_phone", phone);
            obj.UpdateParameters.Add("Admin_Address", Addr);
            obj.Update();
            Panel4.Enabled = false;
            Button3.Enabled = true;
        }
    }
}