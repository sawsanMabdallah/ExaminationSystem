using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Question : System.Web.UI.Page
{
    ObjectDataSource obj = new ObjectDataSource();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        obj.TypeName = "BussniessLayerQuestion";
        obj.InsertMethod = "InsertQuestion";
        obj.InsertParameters.Add("Q_id",TextBox4.Text);
        obj.InsertParameters.Add("Q_body", TextBox5.Text);
        obj.InsertParameters.Add("Q_type", TextBox6.Text);
        obj.InsertParameters.Add("Q_Answer", TextBox7.Text);
        obj.InsertParameters.Add("Q_Grade", TextBox8.Text);
        obj.InsertParameters.Add("Crs_id", DropDownList2.SelectedValue);
        obj.Insert();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var row = GridView1.SelectedRow;
        Label ID = row.FindControl("Label1") as Label;
        Session["QuestID"] = ID;
        //Response.Redirect("choices.aspx");

    }
}