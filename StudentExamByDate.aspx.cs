using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentExamByDate : System.Web.UI.Page
{
    ObjectDataSource obj;
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void btn_search_Click(object sender, EventArgs e)
    {
        obj = new ObjectDataSource();
        obj.TypeName = "BussniessLayerStudents";
        obj.SelectMethod = "StudentExam";
        obj.SelectParameters.Add("date",TextBox_date.Text);
        obj.Select();
        GridView1.DataSource = obj;
        GridView1.DataBind();
    }
}