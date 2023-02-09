<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="MyWebApplication.PagesForVisitors.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style type="text/css">
        .auto-style21 {
            height: 20px;
            color: #FFFF00;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <table class="auto-style7" style="height: 1038px">
        <tr>
            <td class="auto-style21">Product&nbsp; By Category</td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="dlCategories" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyField="IdCategory" DataSourceID="SqlDataSource1" GridLines="Both" OnItemCommand="dlCategories_ItemCommand" style="margin-right: 4px; margin-top: 0px" Height="16px" Width="439px">
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <ItemStyle BackColor="White" ForeColor="#003399" />
                    <ItemTemplate>
                        <br />
                        CategoryName:
                        <asp:Label ID="CategoryNameLabel" runat="server" Text='<%# Eval("CategoryName") %>' />
                        <br />
                        CategoryLogo:<br />
                        <asp:ImageButton ID="imgProduct" runat="server" Height="129px" ImageUrl='<%# "~/Images/Categories/"+ Eval("CategoryLogo") %>' Width="211px" />
                        <br />
                        <asp:Label ID="CategoryLogoLabel" runat="server" Text='<%# Eval("CategoryLogo") %>' />
                        <br />
<br />
                        <asp:HiddenField ID="HiddenField1" runat="server" Value='<%# Eval("IdCategory") %>' />
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                </asp:DataList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyConnection %>" ProviderName="<%$ ConnectionStrings:MyConnection.ProviderName %>" SelectCommand="SELECT * FROM [Categories]"></asp:SqlDataSource>
            </td>
        </tr>
    </table>
</asp:Content>
