<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="wfManufacturers.aspx.cs" Inherits="MyWebApplication.PagesForVisitors.wfManufacturers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style type="text/css">
        .auto-style13 {}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <table class="auto-style7">
        <tr>
            <td style="color: #FFFF00">Product By Manufacturers</td>
        </tr>
        <tr>
            <td class="auto-style13">
                <asp:DataList ID="dlManufacturers" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyField="IdManufacturer" DataSourceID="SqlDataSource1" GridLines="Both" style="margin-right: 0px" Width="464px" OnItemCommand="dlManufacturers_ItemCommand" Height="16px">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <ItemTemplate>
                        IdManufacturer:
                        <asp:Label ID="IdManufacturerLabel" runat="server" Text='<%# Eval("IdManufacturer") %>' />
                        <br />
                        ManufacturerName:
                        <asp:Label ID="ManufacturerNameLabel" runat="server" Text='<%# Eval("ManufacturerName") %>' />
                        <br />
                        ManufacturerLogo:
                        <asp:Label ID="ManufacturerLogoLabel" runat="server" Text='<%# Eval("ManufacturerLogo") %>' />
                        <br />
                        <asp:ImageButton ID="imgProduct" runat="server" Height="81px" ImageUrl='<%# "~/Images/Manufacturers/"+ Eval("ManufacturerLogo") %>' Width="134px" />
                        <asp:HiddenField ID="HiddenField1" runat="server" Value='<%# Eval("IdManufacturer") %>' />
<br />
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyConnection %>" ProviderName="<%$ ConnectionStrings:MyConnection.ProviderName %>" SelectCommand="SELECT * FROM [Manufactureres]"></asp:SqlDataSource>
                <asp:Label ID="lblMsg" runat="server" style="color: #FFFF00"></asp:Label>
            </td>
        </tr>
        </table>
</asp:Content>
<asp:Content ID="Content4" runat="server" contentplaceholderid="ContentPlaceHolder5">
                        <asp:Image ID="Image17" runat="server" Height="1242px" ImageUrl="~/Images/General/battlefield_1_soldiers_5k-HD (1).jpg"  Width="480px" ImageAlign="Baseline" style="margin-bottom: 7px" />
                    </asp:Content>
<asp:Content ID="Content5" runat="server" contentplaceholderid="ContentPlaceHolder6">
                        <asp:Image ID="Image18" runat="server" Height="1242px" ImageUrl="~/Images/General/battlefield_1_soldiers_5k-HD.jpg" style="margin-right: 2px; margin-top: 0px" Width="478px" />
                    </asp:Content>

