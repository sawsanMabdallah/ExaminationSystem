﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="GetTopicNameByCrsId.aspx.cs" Inherits="GetTopicNameByCrsId" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; height: 239px;">
        <tr>
            <td style="height: 73px; width: 74px">&nbsp;</td>
            <td style="height: 73px; width: 170px">&nbsp;</td>
            <td style="height: 73px; width: 210px"></td>
            <td style="height: 73px"></td>
        </tr>
        <tr>
            <td style="width: 74px; height: 76px"></td>
            <td style="width: 170px; height: 76px">
                <asp:Label ID="Label1_Crs_Id" runat="server" BackColor="#0099FF" BorderStyle="Double" Font-Size="Large" ForeColor="Black" Height="38px" Text="Course_id" Width="115px"></asp:Label>
            </td>
            <td style="width: 210px; height: 76px">
                <asp:TextBox ID="TextBox1_Crs_id" runat="server" Height="29px" style="margin-left: 20px" Width="166px"></asp:TextBox>
            </td>
            <td style="height: 76px"></td>
        </tr>
        <tr>
            <td style="width: 74px">&nbsp;</td>
            <td style="width: 170px">&nbsp;</td>
            <td style="width: 210px">
                <asp:Button ID="Button1_GetTopicName" runat="server" BorderColor="#3399FF" Font-Size="Larger" ForeColor="Black" Height="33px" style="margin-left: 0px" Text="Get Topics" Width="273px" OnClick="Button1_GetAllstudent_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

