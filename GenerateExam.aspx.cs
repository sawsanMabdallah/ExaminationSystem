using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GenerateExam : System.Web.UI.Page
{
    ObjectDataSource obj;
    protected void Page_Load(object sender, EventArgs e)
    {
        obj = new ObjectDataSource();
    }

    protected void btn_generate_Click(object sender, EventArgs e)
    {
        obj.TypeName = "BussniessLayerStudents";
        obj.InsertMethod = "GenerateExam";
        obj.InsertParameters.Add("Crs_name", DropDownListCRsName.SelectedValue);
        obj.InsertParameters.Add("MCQ",TextMCq.Text);
        obj.InsertParameters.Add("TF", TextTF.Text);
        obj.Insert();
        LabelMsg.Text += "Exam Generated";
        LabelMsg.Text += Environment.NewLine;
        Session.Add("CourseName", DropDownListCRsName.SelectedValue);
        Session.Add("MCQNumber",int.Parse(TextMCq.Text));
        Session.Add("TFNumber", int.Parse(TextTF.Text));


    }
}