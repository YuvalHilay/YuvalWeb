<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="MyWebApplication.PagesForAdmins.Catalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style type="text/css">
        .auto-style14 {
            height: 20px;
            width: 1159px;
        }
        .auto-style16 {
            height: 25px;
            width: 1159px;
        }
        .auto-style17 {
            height: 44px;
            width: 1159px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <table class="auto-style7" style="height: 262px">
        <tr>
            <td style="text-align: center; font-weight: 700; font-size: xx-large; background-color: #FFFF00;" class="auto-style16">קטלוג המוצרים</td>
        </tr>
        <tr>
            <td class="auto-style17">
                <asp:GridView ID="gvCatalog" runat="server" AutoGenerateSelectButton="True" DataKeyNames="IDProduct" Height="114px" OnSelectedIndexChanged="gvCatalog_SelectedIndexChanged1" Width="1158px" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="0" style="margin-top: 0px" AllowPaging="True">
                    <Columns>
                        <asp:BoundField DataField="IDProduct" HeaderText="קוד מוצר" />
                        <asp:BoundField HeaderText="שם מוצר" DataField="ProductName" />
                        <asp:BoundField DataField="Price" DataFormatString="{0:c}" HeaderText="מחיר" />
                        <asp:ImageField DataImageUrlField="ProductImage" DataImageUrlFormatString="~/Images/Products/{0}" HeaderText="תמונת מוצר">
                            <ControlStyle Height="150px" />
                        </asp:ImageField>
                        <asp:BoundField DataField="ManufacturerName" HeaderText="שם יצרן" />
                        <asp:CheckBoxField DataField="Active" Text="? פעיל" />
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
            <td class="auto-style14">
                <asp:Label ID="lblMsg" runat="server" style="text-align: center" ForeColor="Yellow"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content4" runat="server" contentplaceholderid="ContentPlaceHolder5">
                        <asp:Image ID="Image17" runat="server" Height="1826px" ImageUrl="~/Images/General/battlefield_1_soldiers_5k-HD (1).jpg"  Width="480px" ImageAlign="Baseline" style="margin-bottom: 7px" />
                    </asp:Content>
<asp:Content ID="Content5" runat="server" contentplaceholderid="ContentPlaceHolder6">
                        <asp:Image ID="Image18" runat="server" Height="1826px" ImageUrl="~/Images/General/battlefield_1_soldiers_5k-HD.jpg" style="margin-right: 2px; margin-top: 0px" Width="478px" />
                    </asp:Content>

