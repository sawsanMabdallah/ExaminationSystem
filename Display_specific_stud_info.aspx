<%@ Page Title="" Language="C#" MasterPageFile="~/MasterInstructor.master" AutoEventWireup="true" CodeFile="Display_specific_stud_info.aspx.cs" Inherits="Display_specific_stud_info" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="St_id" DataValueField="St_id">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="select_students" TypeName="BussinessLayerInstructor"></asp:ObjectDataSource>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource2" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="St_id">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("St_id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="St_Fname">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("St_Fname") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="St_Lname">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("St_Lname") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="St_phone">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("St_phone") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="St_address">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("St_address") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Dept_id">
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("Dept_id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
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
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="specific_stud_info" TypeName="BussinessLayerInstructor">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="st_id" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
</asp:Content>

