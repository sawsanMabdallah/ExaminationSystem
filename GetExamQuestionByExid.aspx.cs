using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetExamQuestionByExid : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_GetAllstudent_Click(object sender, EventArgs e)
    {
        Session.Add("Exam_id_forReport", TextBox1_ExamId.Text);
        Response.Redirect("QuestionByExIdReport.aspx");
    }
}