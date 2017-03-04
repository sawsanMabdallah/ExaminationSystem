<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="GetStudentAnswersWithModelAnswers.aspx.cs" Inherits="GetStudentAnswersWithModelAnswers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; height: 239px;">
        <tr>
            <td style="height: 58px; " colspan="4">
            <asp:Label ID="Label1" runat="server"  BackColor="White"  Font-Bold="True" Font-Size="Medium" ForeColor="Black" Height="38px" style="margin-left: 138px; text-align:center;padding-left:10px;margin-top: 5px; margin-bottom: 10px" Text="Student Answer With Model Answer" Width="363px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 58px; width: 74px"></td>
            <td style="height: 58px; width: 196px">
                <asp:Label ID="Label1_Exam_id" runat="server" BackColor="#0099FF" BorderStyle="Double" Font-Size="Large" ForeColor="Black" Height="38px" Text="Exam_id" Width="115px"></asp:Label>
            </td>
            <td style="height: 58px; width: 198px">
                <asp:DropDownList ID="DropDownList1" runat="server" Font-Size="Medium" ForeColor="Black" Height="36px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="177px" AutoPostBack="True" AppendDataBoundItems="True">
                    <asp:ListItem Value="0">select exam id</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="height: 58px"></td>
        </tr>
        <tr>
            <td style="width: 74px; height: 76px"></td>
            <td style="width: 196px; height: 76px">
                <asp:Label ID="Label1_StdID" runat="server" BackColor="#0099FF" BorderStyle="Double" Font-Size="Large" ForeColor="Black" Height="38px" Text="Student_Name" Width="161px"></asp:Label>
            </td>
            <td style="width: 198px; height: 76px">
                <asp:DropDownList ID="DropDownList2" runat="server" Font-Size="Large" ForeColor="Black" Height="28px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="184px" AutoPostBack="True" AppendDataBoundItems="True">
                    <asp:ListItem Value="0">select student name</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="height: 76px"></td>
        </tr>
        <tr>
            <td style="width: 74px">&nbsp;</td>
            <td style="width: 196px">&nbsp;</td>
            <td style="width: 198px">
                <asp:Button ID="Button1_GetStudentAnswer" runat="server" BorderColor="#3399FF" Font-Size="Larger" ForeColor="Black" Height="44px" style="margin-left: 0px" Text="Search" Width="236px" OnClick="Button1_GetAllstudent_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

