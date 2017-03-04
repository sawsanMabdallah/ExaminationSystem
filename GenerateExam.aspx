<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="GenerateExam.aspx.cs" Inherits="GenerateExam" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; height: 164px;">
    <tr>
        <td style="width: 145px">
            <asp:Label ID="Label1" runat="server" Text="Course Name"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="DropDownListCRsName" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Crs_name" DataValueField="Crs_name" AutoPostBack="True">
            </asp:DropDownList>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 145px">
            <asp:Label ID="Label2" runat="server" Text="Number of MCQ"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextMCq" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 145px">
            <asp:Label ID="Label3" runat="server" Text="Number of T/F"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextTF" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 145px">&nbsp;</td>
        <td>
            <asp:Button ID="btn_generate" runat="server" OnClick="btn_generate_Click" Text="Generate" PostBackUrl="~/ExamPage.aspx" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 145px">&nbsp;</td>
        <td>
            <asp:Label ID="LabelMsg" runat="server"></asp:Label>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="AllCourse" TypeName="BussniessLayerStudents"></asp:ObjectDataSource>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

