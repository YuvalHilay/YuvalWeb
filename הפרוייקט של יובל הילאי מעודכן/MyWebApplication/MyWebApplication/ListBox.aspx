<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="ListBox.aspx.cs" Inherits="MyWebApplication.ListBox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <asp:ListBox ID="ListBox1" runat="server" Height="238px" SelectionMode="Multiple" Width="104px"></asp:ListBox>
&nbsp;&nbsp;
    <asp:Button ID="btnRemoveAll" runat="server" Text="&lt;&lt;" OnClick="btnRemoveAll_Click" />
    <asp:Button ID="btnAddAll" runat="server" OnClick="btnAddAll_Click1" Text="&gt;&gt;" />
    <asp:Button ID="btnRemoveItem" runat="server" Text="&lt;" Width="23px" OnClick="btnRemoveItem_Click" />
&nbsp;<asp:Button ID="btnAddItem" runat="server" OnClick="btnAddItem_Click1" Text="&gt;" />
    <asp:ListBox ID="ListBox2" runat="server" Height="235px" SelectionMode="Multiple" style="margin-left: 11px; margin-top: 0px" Width="100px"></asp:ListBox>
&nbsp;<br />
    <asp:Label ID="lblMsg" runat="server"></asp:Label>
&nbsp;
</asp:Content>
