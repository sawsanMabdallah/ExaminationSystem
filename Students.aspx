<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="Students.aspx.cs" Inherits="Students" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView_student" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" DataKeyNames="St_id">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
            <asp:TemplateField HeaderText="Student ID">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("St_id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Student Fname">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("St_Fname") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("St_Fname") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Student Lname">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("St_Lname") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("St_Lname") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Student Phone">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("St_phone") %>'></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="phone must be 12 digit" ValidationExpression="^[0-9]{12}$"></asp:RegularExpressionValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("St_phone") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Student Address">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("St_address") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("St_address") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Department id">
                <EditItemTemplate>
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Dept_name" DataValueField="Dept_id" SelectedValue='<%# Bind("Dept_id") %>'>
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectDepartment" TypeName="BussniessLayerStudents"></asp:ObjectDataSource>
                </EditItemTemplate>
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
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="DeleteStudent" InsertMethod="InsertStudent" SelectMethod="SelectStudent" TypeName="BussniessLayerStudents" UpdateMethod="UpdateStudent">
        <DeleteParameters>
            <asp:Parameter Name="St_id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="St_id" Type="String" />
            <asp:Parameter Name="St_Fname" Type="String" />
            <asp:Parameter Name="St_Lname" Type="String" />
            <asp:Parameter Name="St_phone" Type="String" />
            <asp:Parameter Name="St_address" Type="String" />
            <asp:Parameter Name="Dept_id" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="St_id" Type="String" />
            <asp:Parameter Name="St_Fname" Type="String" />
            <asp:Parameter Name="St_Lname" Type="String" />
            <asp:Parameter Name="St_phone" Type="String" />
            <asp:Parameter Name="St_address" Type="String" />
            <asp:Parameter Name="Dept_id" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    <br />
    <br />
    <table style="width:100%;">
        <tr>
            <td style="height: 18px; width: 193px">
                <asp:Label ID="Label7" runat="server" Text="Student ID"></asp:Label>
            </td>
            <td style="height: 18px; width: 200px">
                <asp:TextBox ID="TextBoxID" runat="server" Width="136px"></asp:TextBox>
            </td>
            <td style="height: 18px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxID" Display="Dynamic" ErrorMessage="*" ValidationGroup="v1"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidatorID" runat="server" ControlToValidate="TextBoxID" Display="Dynamic" ErrorMessage="ID between  1 and 1000" MaximumValue="1000" MinimumValue="1" Type="Integer" ValidationGroup="v1"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 193px">
                <asp:Label ID="Label8" runat="server" Text="First Name"></asp:Label>
            </td>
            <td style="width: 200px">
                <asp:TextBox ID="TextBoxFname" runat="server" Width="136px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxFname" ErrorMessage="*" ValidationGroup="v1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 193px">
                <asp:Label ID="Label10" runat="server" Text="Last Name"></asp:Label>
            </td>
            <td style="width: 200px">
                <asp:TextBox ID="TextBoxLname" runat="server" Width="136px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxLname" ErrorMessage="*" ValidationGroup="v1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 193px; height: 22px">
                <asp:Label ID="Label9" runat="server" Text="Phone"></asp:Label>
            </td>
            <td style="width: 200px; height: 22px">
                <asp:TextBox ID="TextBoxPhone" runat="server" Width="136px"></asp:TextBox>
            </td>
            <td style="height: 22px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxPhone" ErrorMessage="*" ValidationGroup="v1"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorPhone" runat="server" ErrorMessage="phone must be 12 digit" ValidationExpression="^[0-9]{12}$" ControlToValidate="TextBoxPhone" ValidationGroup="v1"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 193px">
                <asp:Label ID="Label11" runat="server" Text="Address"></asp:Label>
            </td>
            <td style="width: 200px">
                <asp:TextBox ID="TextBoxAddress" runat="server" Width="136px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxAddress" Display="Dynamic" ErrorMessage="*" ValidationGroup="v1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 193px">
                <asp:Label ID="Label12" runat="server" Text="Department ID"></asp:Label>
            </td>
            <td style="width: 200px">
                <asp:DropDownList ID="DropDownListDept" runat="server" DataSourceID="ObjectDataSource2" DataTextField="Dept_name" DataValueField="Dept_id">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectDepartment" TypeName="BussniessLayerStudents"></asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 193px">&nbsp;</td>
            <td style="width: 200px">
                <asp:Button ID="btn_insert" runat="server" Text="Insert" Width="114px" OnClick="btn_insert_Click" ValidationGroup="v1" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

