<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="GetTopicNameByCrsId.aspx.cs" Inherits="GetTopicNameByCrsId" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; height: 239px;">
        <tr>
            <td style="height: 73px; " colspan="4">
            <asp:Label ID="Label1" runat="server"  BackColor="White"  Font-Bold="True" Font-Size="Medium" ForeColor="Black" Height="38px" style="margin-left: 138px; text-align:center;padding-left:10px;margin-top: 5px; margin-bottom: 10px" Text="Topics Per Course" Width="341px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 74px; height: 76px"></td>
            <td style="width: 170px; height: 76px">
                <asp:Label ID="Label1_Crs_Id" runat="server" BackColor="#0099FF" BorderStyle="Double" Font-Size="Large" ForeColor="Black" Height="38px" Text="Course_Name" Width="115px"></asp:Label>
            </td>
            <td style="width: 210px; height: 76px">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Font-Size="Medium" ForeColor="Black" Height="29px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="191px" AppendDataBoundItems="True">
                    <asp:ListItem Value="0">Select Course Name</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="height: 76px"></td>
        </tr>
        <tr>
            <td style="width: 74px">&nbsp;</td>
            <td style="width: 170px">&nbsp;</td>
            <td style="width: 210px">
                <asp:Button ID="Button1_GetTopicName" runat="server" BorderColor="#3399FF" Font-Size="Larger" ForeColor="Black" Height="51px" style="margin-left: 6px" Text="Search" Width="200px" OnClick="Button1_GetAllstudent_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

