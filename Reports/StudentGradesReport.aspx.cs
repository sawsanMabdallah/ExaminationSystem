using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentGradesReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ReportDocument crp = new ReportDocument();
        crp.Load(Server.MapPath("~/CrystalReportStudentGrades.rpt"));
        StudentGrades dsStu = GetData();
        crp.SetDataSource(dsStu);
        CrystalReportViewer1.ReportSource = crp;
    }
    private StudentGrades GetData()
    {
        string conStr = "Data Source= .;Initial Catalog=AdvSQL;Integrated Security=True";

        using (SqlConnection con = new SqlConnection(conStr))
        {
            using (SqlDataAdapter sda = new SqlDataAdapter())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "GetStudentGrade";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter par1 = new SqlParameter("@St_id", SqlDbType.Int, 4);
                cmd.Parameters.Add(par1);
                par1.Value = int.Parse(Session["Student_id"].ToString());
                sda.SelectCommand = cmd;
                using (StudentGrades  dsSt = new StudentGrades())
                {
                    sda.Fill(dsSt, "DataTable1");
                    return dsSt;
                }
            }
        }
    }
}