using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Department : System.Web.UI.Page
{
    //ObjectDataSource obj = new ObjectDataSource();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!Page.IsPostBack)
        //{
        //    obj = new ObjectDataSource();
        //    obj.TypeName = "BussniessLayerDepartment";
        //    obj.SelectMethod = "selectDepartment";
        //    obj.Select();
        //    GridView1.DataSource = obj;
        //    GridView1.DataBind();
        //    Session.Add("obj1",obj);
        //}
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        var id = Dropmanagerid.SelectedValue;
        if (IsValid)
        {
            ObjectDataSource1.InsertParameters["Dept_id"].DefaultValue = txtdeptid.Text;
            ObjectDataSource1.InsertParameters["Dept_name"].DefaultValue = txtdeptname.Text;
            ObjectDataSource1.InsertParameters["Manger_id"].DefaultValue =id;
            ObjectDataSource1.Insert();
        }
    }
}