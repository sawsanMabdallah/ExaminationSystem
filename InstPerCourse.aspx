<%@ Page Title="" Language="C#" MasterPageFile="~/MasterInstructor.master" AutoEventWireup="true" CodeFile="InstPerCourse.aspx.cs" Inherits="InstPerCourse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Course Id"></asp:Label>
            </td>
            <td style="width: 505px">
                <asp:DropDownList ID="Dropcourse_Id" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource2" DataTextField="Crs_name" DataValueField="Crs_id">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="select_ins_cours" TypeName="BussinessLayerInstructor" OnSelecting="ObjectDataSource2_Selecting"></asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 505px">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None">
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
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="selectInst_percourse" TypeName="BussinessLayerInstructor">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="Dropcourse_Id" Name="crs_id" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 505px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>