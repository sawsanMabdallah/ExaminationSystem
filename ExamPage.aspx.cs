using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ExamPage : System.Web.UI.Page
{
    string[][] controlArray = new string[10][];
    SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = AdvSQL; Integrated Security = True");
    DataSet ds2 = new DataSet();
    DataSet ds = new DataSet();
    string Ans1, Ans2, Ans3, Ans4, Ans5, Ans6, Ans7, Ans8, Ans9, Ans10;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)

        {
            DataSet ds1 = GetData2();
            for (int i = 0; i < 10; i++)
            {
                int Qid = int.Parse(ds1.Tables["Questions"].Rows[i][0].ToString());
                DataSet ds = GetData1(Qid);
                int type = int.Parse(ds1.Tables["Questions"].Rows[i][2].ToString());
                if (type == 0)
                {
                    controlArray[i] = new string[4]
                    {
                    ds.Tables["Choices"].Rows[0][0].ToString(),
            ds.Tables["Choices"].Rows[1][0].ToString(),
             ds.Tables["Choices"].Rows[2][0].ToString(),
            ds.Tables["Choices"].Rows[3][0].ToString()
                    };

                }

                else
                {
                    controlArray[i] = new string[2]
                     {
                    ds.Tables["Choices"].Rows[0][0].ToString(),
                    ds.Tables["Choices"].Rows[1][0].ToString() };

                }

            }

            RadioButtonList1.DataSource = controlArray[0];
            RadioButtonList1.DataBind();
            RadioButtonList2.DataSource = controlArray[1];
            RadioButtonList2.DataBind();
            RadioButtonList3.DataSource = controlArray[2];
            RadioButtonList3.DataBind();
            RadioButtonList4.DataSource = controlArray[3];
            RadioButtonList4.DataBind();
            RadioButtonList5.DataSource = controlArray[4];
            RadioButtonList5.DataBind();
            RadioButtonList6.DataSource = controlArray[5];
            RadioButtonList6.DataBind();
            RadioButtonList7.DataSource = controlArray[6];
            RadioButtonList7.DataBind();
            RadioButtonList8.DataSource = controlArray[7];
            RadioButtonList8.DataBind();
            RadioButtonList9.DataSource = controlArray[8];
            RadioButtonList9.DataBind();
            RadioButtonList10.DataSource = controlArray[9];
            RadioButtonList10.DataBind();
            Label1.Text = ds1.Tables["Questions"].Rows[0][1].ToString();
            Label2.Text = ds1.Tables["Questions"].Rows[1][1].ToString();
            Label3.Text = ds1.Tables["Questions"].Rows[2][1].ToString();
            Label4.Text = ds1.Tables["Questions"].Rows[3][1].ToString();
            Label5.Text = ds1.Tables["Questions"].Rows[4][1].ToString();
            Label6.Text = ds1.Tables["Questions"].Rows[5][1].ToString();
            Label7.Text = ds1.Tables["Questions"].Rows[6][1].ToString();
            Label8.Text = ds1.Tables["Questions"].Rows[7][1].ToString();
            Label9.Text = ds1.Tables["Questions"].Rows[8][1].ToString();
            Label10.Text = ds1.Tables["Questions"].Rows[9][1].ToString();
        }
    }

    private DataSet GetData1(int Qid)
    {
        SqlDataAdapter sda = new SqlDataAdapter();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "select[dbo].[Choices].MCQ from [dbo].[Choices] where[dbo].[Choices].Q_id=" + Qid;
        sda.SelectCommand = cmd;
        ds2.Clear();
        sda.Fill(ds2, "choices");
        return ds2;
    }
    private DataSet GetData2()
    {
        SqlDataAdapter sda = new SqlDataAdapter();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "GenerateExam";
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter par1 = new SqlParameter("@Crs_name", SqlDbType.VarChar, 50);
        SqlParameter par2 = new SqlParameter("@MCQ", SqlDbType.Int, 4);
        SqlParameter par3 = new SqlParameter("@TF", SqlDbType.Int, 4);
        cmd.Parameters.Add(par1);
        cmd.Parameters.Add(par2);
        cmd.Parameters.Add(par3);
        par1.Value = "C#";
        par2.Value = 5;
        par3.Value = 5;
        //   par1.Value = int.Parse(Session["Dept_id_forReport"].ToString());
        sda.SelectCommand = cmd;

        sda.Fill(ds, "Questions");
        return ds;
    }








    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Ans1 = RadioButtonList1.SelectedItem.Text;
    }

    protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Ans2 = RadioButtonList2.SelectedItem.Text;
    }

    protected void RadioButtonList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        Ans3 = RadioButtonList3.SelectedItem.Text;
    }

    protected void RadioButtonList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        Ans4 = RadioButtonList4.SelectedItem.Text;
    }

    protected void RadioButtonList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        Ans5 = RadioButtonList5.SelectedItem.Text;
    }

    protected void RadioButtonList6_SelectedIndexChanged(object sender, EventArgs e)
    {
        Ans6 = RadioButtonList6.SelectedItem.Text;
    }

    protected void RadioButtonList7_SelectedIndexChanged(object sender, EventArgs e)
    {
        Ans7 = RadioButtonList7.SelectedItem.Text;
    }

    protected void RadioButtonList8_SelectedIndexChanged(object sender, EventArgs e)
    {
        Ans8 = RadioButtonList8.SelectedItem.Text;
    }

    protected void RadioButtonList9_SelectedIndexChanged(object sender, EventArgs e)
    {
        Ans9 = RadioButtonList9.SelectedItem.Text;
    }

    protected void RadioButtonList10_SelectedIndexChanged(object sender, EventArgs e)
    {
        Ans10 = RadioButtonList10.SelectedItem.Text;
    }
}