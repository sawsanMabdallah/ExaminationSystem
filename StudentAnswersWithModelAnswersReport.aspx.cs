using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentAnswersWithModelAnswersReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ReportDocument crp = new ReportDocument();
        crp.Load(Server.MapPath("~/CrystalReportStudentAnswers.rpt"));
        StudentAnswers dsStu = GetData();
        crp.SetDataSource(dsStu);
        CrystalReportViewer1.ReportSource = crp;
    }
    private StudentAnswers GetData()
    {
        string conStr = "Data Source=.;Initial Catalog=AdvSQL;Integrated Security=True";

        using (SqlConnection con = new SqlConnection(conStr))
        {
            using (SqlDataAdapter sda = new SqlDataAdapter())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "getQuestionwithStudentId";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter par1 = new SqlParameter("@exid", SqlDbType.Int, 4);
                SqlParameter par2 = new SqlParameter("@stid", SqlDbType.Int, 4);
                cmd.Parameters.Add(par1);
                cmd.Parameters.Add(par2);
                par1.Value = int.Parse(Session["Exam_id_forReport"].ToString());
                par2.Value = int.Parse(Session["Student_id_forReport"].ToString());
                sda.SelectCommand = cmd;
                using (StudentAnswers dsStudents = new StudentAnswers())
                {
                    sda.Fill(dsStudents, "DataTable1");
                    return dsStudents;
                }
            }
        }
    }
}