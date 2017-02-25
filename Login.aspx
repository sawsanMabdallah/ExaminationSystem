<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAnonymous.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%;">
    <tr>
        <td style="width: 69px">&nbsp;</td>
        <td rowspan="3" style="width: 475px">
            <asp:Login ID="Login1" runat="server" Height="281px" style="margin-left: 0px" Width="470px" CreateUserUrl="~/Welcome.aspx">
            </asp:Login>
        </td>
    </tr>
    <tr>
        <td style="width: 69px">&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 69px">&nbsp;</td>
    </tr>
</table>
</asp:Content>

