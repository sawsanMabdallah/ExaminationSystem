﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="StudentExamByDate.aspx.cs" Inherits="StudentExamByDate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="width: 124px">&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Date:"></asp:Label>
                &nbsp;</td>
            <td style="width: 30px">
                <br />
                <asp:TextBox ID="TextBox_date" runat="server" Width="124px"></asp:TextBox>
&nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox_date" ErrorMessage="Date Format YYYY/MM/DD" MaximumValue="9999/12/28" MinimumValue="1000/12/28" Type="Date"></asp:RangeValidator>
            </td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_search" runat="server" OnClick="btn_search_Click" Text="Search" />
            </td>
        </tr>
        <tr>
            <td style="width: 124px">&nbsp;</td>
            <td style="width: 30px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 124px">&nbsp;</td>
            <td style="width: 30px">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

