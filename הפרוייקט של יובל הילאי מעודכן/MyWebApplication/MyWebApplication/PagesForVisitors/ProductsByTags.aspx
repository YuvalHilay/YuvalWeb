<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="ProductsByTags.aspx.cs" Inherits="MyWebApplication.PagesForVisitors.ProductsByTags" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:TextBox ID="tbxTag" runat="server" Width="504px"></asp:TextBox>
    <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" style="background-color: #FFFF00" Text="Search" />
    <asp:Button ID="btnChooseNewTag" runat="server" OnClick="btnChooseNewTag_Click" style="background-color: #FFFF00" Text="Choose New Tag" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    <asp:GridView ID="gvAllTags" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="232px" OnSelectedIndexChanged="gvAllTags_SelectedIndexChanged" Width="1092px">
        <Columns>
            <asp:BoundField DataField="Tag" HeaderText="Tag" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>
    <br />
    <asp:GridView ID="gvProductsByTag" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="IDProduct" Height="245px" OnSelectedIndexChanged="gvProductsByTag_SelectedIndexChanged" style="text-align: center" Visible="False" Width="1091px">
        <Columns>
            <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
            <asp:BoundField DataField="ProductDescription" HeaderText="Description" />
            <asp:ImageField DataImageUrlField="ProductImage" DataImageUrlFormatString="~/Images/Products/{0}" HeaderText="Image ">
                <ControlStyle Height="150px" Width="150px" />
            </asp:ImageField>
            <asp:BoundField DataField="Price" DataFormatString="{0:c}" HeaderText="Price" />
            <asp:BoundField DataField="IDProduct" HeaderText="Product ID" />
            <asp:BoundField DataField="Tag" HeaderText="Tag" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>
    <br />
    <br />
    <br />
    <asp:Label ID="lblMsg" runat="server" style="color: #FFFF00"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
