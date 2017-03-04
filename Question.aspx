<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="Question.aspx.cs" Inherits="Question" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Q_id" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
            <asp:TemplateField HeaderText="ID">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("Q_id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Body">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Q_body") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Q_body") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Type">
                <EditItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("Q_type") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Q_type") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Answer">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Q_Answer") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("Q_Answer") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Grade">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Q_Grade") %>'></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Grade from 1 to 10" ForeColor="Black" MaximumValue="10" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("Q_Grade") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Course">
                <EditItemTemplate>
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="Crs_name" DataValueField="Crs_id" SelectedValue='<%# Bind("Crs_id") %>'>
                    </asp:DropDownList>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("Crs_id") %>'></asp:Label>
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
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="DeleteQuestion" InsertMethod="InsertQuestion" SelectMethod="SelectQuestion" TypeName="BussniessLayerQuestion" UpdateMethod="UpdateQuestion">
        <DeleteParameters>
            <asp:Parameter Name="Q_id" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Q_id" Type="Int32" />
            <asp:Parameter Name="Q_body" Type="String" />
            <asp:Parameter Name="Q_type" Type="String" />
            <asp:Parameter Name="Q_Answer" Type="String" />
            <asp:Parameter Name="Q_Grade" Type="String" />
            <asp:Parameter Name="Crs_id" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Q_id" Type="String" />
            <asp:Parameter Name="Q_body" Type="String" />
            <asp:Parameter Name="Q_type" Type="String" />
            <asp:Parameter Name="Q_Answer" Type="String" />
            <asp:Parameter Name="Q_Grade" Type="String" />
            <asp:Parameter Name="Crs_id" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    <br />
    <table style="width:100%;">
        <tr>
            <td style="width: 121px">
                <asp:Label ID="Label8" runat="server" Text="ID"></asp:Label>
            </td>
            <td style="width: 259px">
                <asp:TextBox ID="TextBox4" runat="server" Width="189px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="*" ForeColor="Black" ValidationGroup="V"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="Range between 1 to 10000" ForeColor="Black" MaximumValue="10000" MinimumValue="1" Type="Integer"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 121px">
                <asp:Label ID="Label9" runat="server" Text="Body"></asp:Label>
            </td>
            <td style="width: 259px">
                <asp:TextBox ID="TextBox5" runat="server" Width="186px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox5" ErrorMessage="*" ForeColor="Black" ValidationGroup="V"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 121px">
                <asp:Label ID="Label10" runat="server" Text="Type"></asp:Label>
            </td>
            <td style="width: 259px">
                <asp:TextBox ID="TextBox6" runat="server" Width="186px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox6" ErrorMessage="*" ForeColor="Black" ValidationGroup="V"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TextBox6" ErrorMessage="Type 0 or 1" ForeColor="Black" MaximumValue="1" MinimumValue="0"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 121px">
                <asp:Label ID="Label11" runat="server" Text="Answer"></asp:Label>
            </td>
            <td style="width: 259px">
                <asp:TextBox ID="TextBox7" runat="server" Width="185px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox7" ErrorMessage="*" ForeColor="Black" ValidationGroup="V"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 121px">
                <asp:Label ID="Label12" runat="server" Text="Grade"></asp:Label>
            </td>
            <td style="width: 259px">
                <asp:TextBox ID="TextBox8" runat="server" Width="184px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox8" ErrorMessage="*" ForeColor="Black" ValidationGroup="V"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="TextBox8" ErrorMessage="Grade from 1 to 10" ForeColor="Black" MaximumValue="10" MinimumValue="1" Type="Integer"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 121px">
                <asp:Label ID="Label13" runat="server" Text="Course"></asp:Label>
            </td>
            <td style="width: 259px">
                <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="ObjectDataSource2" DataTextField="Crs_name" DataValueField="Crs_id">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectCourse" TypeName="BussniessLayerQuestion"></asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 121px">&nbsp;</td>
            <td style="width: 259px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" ValidationGroup="V" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

