<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="choices.aspx.cs" Inherits="choices" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1">
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectChoices" TypeName="BussniessLayerQuestion">
        <SelectParameters>
            <asp:SessionParameter Name="Q_id" SessionField="QuestID" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

