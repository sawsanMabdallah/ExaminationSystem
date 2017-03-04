using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QuestionByExIdReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ReportDocument crp = new ReportDocument();
        crp.Load(Server.MapPath("~/CrystalReportGetExamQuestionByExId.rpt"));
        Question  dsStu = GetData();
        crp.SetDataSource(dsStu);
        CrystalReportViewer1.ReportSource = crp;
    }
    private Question GetData()
    {
        string conStr = "Data Source= . ;Initial Catalog=AdvSQL;Integrated Security=True";

        using (SqlConnection con = new SqlConnection(conStr))
        {
            using (SqlDataAdapter sda = new SqlDataAdapter())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "getQuestion";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter par1 = new SqlParameter("@exid", SqlDbType.Int, 4);
                cmd.Parameters.Add(par1);
                par1.Value = int.Parse(Session["Exam_id_forReport"].ToString());
                sda.SelectCommand = cmd;
                using (Question dsStudents = new Question())
                {
                   sda.Fill(dsStudents, "DataTable1");
                    return dsStudents;
                }
            }
        }
    }
}