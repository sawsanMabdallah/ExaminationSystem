<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAnonymous.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
    <tr>
        <td colspan="3">
    <h3 style="padding: 0px; margin: 0px 0px 10px; height: 20px; width: 400px; background-color: rgb(19, 149, 202); color: rgb(255, 255, 255); border-bottom: 1px solid rgb(18, 137, 166); border-right: 20px solid rgb(18, 137, 166);">Contact Us</h3>
        </td>
    </tr>
    <tr>
        <td style="width: 107px">
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Small" Text="Address:"></asp:Label>
            <br />
        </td>
        <td>
            <asp:Label ID="Label5" runat="server" Font-Size="X-Small" ForeColor="#333333" Text="8 Km by Cairo / Alexandria Desert Road - 6 October - Building B148, Egypt"></asp:Label>
            <br />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 107px">
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Small" Text="Phone:"></asp:Label>
            <br />
        </td>
        <td>
            <asp:Label ID="Label6" runat="server" Font-Size="X-Small" ForeColor="#333333" Text="(+202) 353-55656"></asp:Label>
            <br />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 107px">
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Small" Text="E-mail:"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label7" runat="server" Font-Size="X-Small" ForeColor="#333333" Text="ITIinfo@iti.gov.eg"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

