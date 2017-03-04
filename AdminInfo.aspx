<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="AdminInfo.aspx.cs" Inherits="AdminInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%;">
    <tr>
        <td style="width: 75px">
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        </td>
        <td style="width: 162px">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 75px; height: 22px">
            <asp:Label ID="Label2" runat="server" Text="Birthdate"></asp:Label>
        </td>
        <td style="width: 162px; height: 22px">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td style="height: 22px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Date Format DD-MM-YYYY" ValidationExpression="^([0-9]{1,2})[./-]+([0-9]{1,2})[./-]+([0-9]{2}|[0-9]{4})$"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 75px">
            <asp:Label ID="Label3" runat="server" Text="phone"></asp:Label>
        </td>
        <td style="width: 162px">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="phone must be 12 digit" ValidationExpression="^[0-9]{12}$"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 75px">
            <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
        </td>
        <td style="width: 162px">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="*"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 75px">&nbsp;</td>
        <td style="width: 162px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Done" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 75px">&nbsp;</td>
        <td style="width: 162px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

