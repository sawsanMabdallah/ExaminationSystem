<%@ Page Title="" Language="C#" MasterPageFile="~/MasterInstructor.master" AutoEventWireup="true" CodeFile="InstructorProfile.aspx.cs" Inherits="InstructorInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; height: 106px;">
        <tr>
            <td style="width: 69px; height: 34px">
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            </td>
            <td style="width: 176px; height: 34px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td style="height: 34px"></td>
        </tr>
        <tr>
            <td style="width: 69px">&nbsp;</td>
            <td style="width: 176px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 69px">
                <asp:Label ID="Label3" runat="server" Text="Department"></asp:Label>
            </td>
            <td style="width: 176px">
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Dept_name" DataValueField="Dept_id">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 69px">&nbsp;</td>
            <td style="width: 176px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save Edit" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 69px">&nbsp;</td>
            <td style="width: 176px">
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="selectDepartment" TypeName="BussniessLayerDepartment"></asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

