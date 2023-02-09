<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="wfCatalog.aspx.cs" Inherits="MyWebApplication.PagesForVisitors.wfCatalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style type="text/css">
        .auto-style14 {}
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <asp:TextBox ID="txtSearch" runat="server" Height="16px" Width="381px"></asp:TextBox>
    <asp:ImageButton ID="ImageSearch" runat="server" Height="22px" ImageUrl="~/Images/icons/SearchButton.jpg" OnClick="ImageSearch_Click" style="margin-left: 0px" Width="28px" />
    <br />
    <asp:Label ID="lblMsg" runat="server" style="color: #FFFF00"></asp:Label>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [IDProduct], [ProductName], [Price], [ProductImage] FROM [spViewActiveProducts]"></asp:SqlDataSource>
    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="SqlDataSource3" Width="1092px" DataKeyNames="IDProduct" Height="264px" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:BoundField DataField="Tag" HeaderText="Tag" SortExpression="Tag" />
            <asp:BoundField DataField="IDProduct" HeaderText="IDProduct" InsertVisible="False" ReadOnly="True" SortExpression="IDProduct" />
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:MyConnection %>" ProviderName="<%$ ConnectionStrings:MyConnection.ProviderName %>" SelectCommand="SELECT [ProductName], [Price], [Tag], [IDProduct] FROM [Products]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MyConnection %>" ProviderName="<%$ ConnectionStrings:MyConnection.ProviderName %>" SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>
    <br />
    <asp:GridView ID="GridView1" runat="server" Height="85px" Width="1095px" AutoGenerateColumns="False" CellPadding="3" DataKeyNames="IDProduct" DataSourceID="SqlDataSource1" CssClass="auto-style14" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" AllowPaging="True">
    <Columns>
        <asp:CommandField ShowSelectButton="True" />
        <asp:BoundField DataField="IDProduct" HeaderText="קוד מוצר" InsertVisible="False" ReadOnly="True" SortExpression="IDProduct" />
        <asp:BoundField DataField="ProductName" HeaderText="שם מוצר" SortExpression="ProductName" />
        <asp:BoundField DataField="Price" HeaderText="מחיר" SortExpression="Price" DataFormatString="{0:c}" />
        <asp:ImageField DataImageUrlField="ProductImage" DataImageUrlFormatString="~/Images/Products/{0}" HeaderText="תמונה" SortExpression="ProductImage">
            <ControlStyle Height="150px" />
            <FooterStyle Height="150px" />
        </asp:ImageField>
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
</asp:Content>


<asp:Content ID="Content4" runat="server" contentplaceholderid="ContentPlaceHolder5">
                        <asp:Image ID="Image17" runat="server" Height="1826px" ImageUrl="~/Images/General/battlefield_1_soldiers_5k-HD (1).jpg"  Width="494px" ImageAlign="Baseline" style="margin-bottom: 7px" />
                    </asp:Content>
<asp:Content ID="Content5" runat="server" contentplaceholderid="ContentPlaceHolder6">
                        <asp:Image ID="Image18" runat="server" Height="1826px" ImageUrl="~/Images/General/battlefield_1_soldiers_5k-HD.jpg" style="margin-right: 2px; margin-top: 0px" Width="494px" />
                    </asp:Content>



