using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InsStuCrsReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ReportDocument crp = new ReportDocument();
        crp.Load(Server.MapPath("~/CrystalReportInsStuCrs.rpt"));
        InsStuCrs dsStu = GetData();
        crp.SetDataSource(dsStu);
        CrystalReportViewer1.ReportSource = crp;
    }
    private InsStuCrs GetData()
    {
        string conStr = ".;Initial Catalog=AdvSQL;Integrated Security=True";

        using (SqlConnection con = new SqlConnection(conStr))
        {
            using (SqlDataAdapter sda = new SqlDataAdapter())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "ins_cources_st";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter par1 = new SqlParameter("@Ins_id", SqlDbType.Int, 4);
                cmd.Parameters.Add(par1);
                par1.Value = int.Parse(Session["Ins_id_forReport"].ToString());
                sda.SelectCommand = cmd;
                using (InsStuCrs dsStudents = new InsStuCrs())
                {
                    sda.Fill(dsStudents, "DataTable1");
                    return dsStudents;
                }
            }
        }
    }
}