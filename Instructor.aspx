<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="Instructor.aspx.cs" Inherits="Instructor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; height: 147px;">
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" DataKeyNames="Ins_id">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                        <asp:TemplateField HeaderText="Ins_id">
                            <EditItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Ins_id") %>'></asp:Label>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Ins_id") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ins_name">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# bind("Ins_name") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Ins_name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Dept_id">
                            <EditItemTemplate>
                                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="Dept_name" DataValueField="Dept_id" SelectedValue='<%# Bind("Dept_id") %>'>
                                </asp:DropDownList>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("Dept_id") %>'></asp:Label>
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
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="DeleteInstructor" InsertMethod="InsertInstructor" SelectMethod="selectInstructor" TypeName="BussinessLayerInstructor" UpdateMethod="UpdateInstructor">
                    <DeleteParameters>
                        <asp:Parameter Name="Ins_id" Type="Int32" />
                        <asp:Parameter Name="Ins_name" Type="String" />
                        <asp:Parameter Name="Dept_id" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Ins_id" Type="Int32" />
                        <asp:Parameter Name="Ins_name" Type="String" />
                        <asp:Parameter Name="Dept_id" Type="Int32" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Ins_id" Type="Int32" />
                        <asp:Parameter Name="Ins_name" Type="String" />
                        <asp:Parameter Name="Dept_id" Type="Int32" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 18px">
                <asp:Label ID="Label5" runat="server" Text="Ins_id"></asp:Label>
            </td>
            <td style="height: 18px">
                <asp:TextBox ID="txtins_id" runat="server"></asp:TextBox>
            </td>
            <td style="height: 18px"></td>
        </tr>
        <tr>
            <td style="height: 22px">
                <asp:Label ID="Label6" runat="server" Text="Ins_name"></asp:Label>
            </td>
            <td style="height: 22px">
                <asp:TextBox ID="txtins_name" runat="server"></asp:TextBox>
            </td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Dept_id"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="Dropdept_id" runat="server" DataSourceID="ObjectDataSource2" DataTextField="Dept_name" DataValueField="Dept_id">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="selectDepartment" TypeName="BussniessLayerDepartment"></asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

