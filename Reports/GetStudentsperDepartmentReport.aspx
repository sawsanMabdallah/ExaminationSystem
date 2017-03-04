<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="GetStudentsperDepartmentReport.aspx.cs" Inherits="GetStudentsperDepartment" %><%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; height: 239px;">
    <tr>
        <td style="height: 73px; " colspan="4">
            <asp:Label ID="Label1" runat="server"  BackColor="White"  Font-Bold="True" Font-Size="Large" ForeColor="Black" Height="38px" style="margin-left: 138px; text-align:center;padding-left:10px;margin-top: 5px; margin-bottom: 10px" Text="Students Per Department" Width="321px"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 74px; height: 76px"></td>
        <td style="width: 153px; height: 76px">
            <asp:Label ID="Label1_Dept_id" runat="server" BackColor="White" Font-Size="Large" ForeColor="Black" Height="38px" Text="Dept_id" Width="115px" style="margin-left: 16px"></asp:Label>
        </td>
        <td style="width: 263px; height: 76px">
            <asp:DropDownList ID="DropDownList1" runat="server" Font-Size="Medium" ForeColor="#666666" Height="34px" Width="181px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
        </td>
        <td style="height: 76px; width: 45px;"></td>
    </tr>
    <tr>
        <td style="width: 74px">&nbsp;</td>
        <td style="width: 153px">&nbsp;</td>
        <td style="width: 263px">
            <asp:Button ID="Button1_GetAllstudent" runat="server" BorderColor="#3399FF" Font-Size="Larger" ForeColor="Black" Height="33px" style="margin-left: 4px" Text="Search" Width="178px" OnClick="Button1_GetAllstudent_Click" />
        </td>
        <td style="width: 45px">&nbsp;</td>
    </tr>
</table>
</asp:Content>

