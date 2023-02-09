<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="wfProductsByManufacturers.aspx.cs" Inherits="MyWebApplication.PagesForVisitors.wfProductsByManufacturers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <table class="auto-style7" style="height: 754px">
        <tr>
            <td style="text-align: center; color: #FFFF00">
                Product By Manufacturers</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="gvProductByManufacturer" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="IdProduct" Height="707px" Width="1160px" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvProductByManufacturer_SelectedIndexChanged" AllowPaging="True">
                    <Columns>
                        <asp:BoundField DataField="IdProduct" HeaderText="IdProduct" />
                        <asp:BoundField DataField="ProductName" HeaderText="ProductName" />
                        <asp:BoundField DataField="ProductDescription" HeaderText="ProductDescription" />
                        <asp:BoundField DataField="Price" HeaderText="Price" />
                        <asp:ImageField DataImageUrlField="ProductImage" HeaderText="ProductImage" DataImageUrlFormatString="~/Images/Products/{0}">
                            <ControlStyle Height="200px" />
                        </asp:ImageField>
                        <asp:CheckBoxField DataField="Active" Text="Active" />
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
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMsg" runat="server" style="color: #FFFF00"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
