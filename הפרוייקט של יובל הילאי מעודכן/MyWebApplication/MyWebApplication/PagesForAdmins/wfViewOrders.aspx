<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="wfViewOrders.aspx.cs" Inherits="MyWebApplication.PagesForAdmins.wfViewOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style type="text/css">
        .auto-style21 {
            font-size: medium;
            color: #FFFF00;
            text-align: center;
        }
        .auto-style22 {
            font-size: medium;
            text-align: center;
        }
        .auto-style23 {
            text-align: center;
        }
        .auto-style24 {
            text-align: center;
            height: 17px;
            font-size: x-large;
            color: #FFFF00;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <table class="auto-style7" style="height: 754px">
        <tr>
            <td class="auto-style24">הזמנות הלקוחות</td>
        </tr>
        <tr>
            <td class="auto-style23">
                <asp:GridView ID="gvOrder" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" CssClass="auto-style21" Height="700px" Width="1159px">
                    <Columns>
                        <asp:BoundField DataField="IDOrder" HeaderText="Order ID" />
                        <asp:BoundField DataField="OrderDate" HeaderText="Order Date" />
                        <asp:BoundField DataField="IdClient" HeaderText="Client ID" />
                        <asp:BoundField DataField="IdAdmin" HeaderText="Admin ID" />
                        <asp:BoundField DataField="IdDeal" HeaderText="Deal ID" />
                        <asp:BoundField DataField="IdDelivery" HeaderText="Delivery ID" />
                        <asp:BoundField DataField="TotalSum" HeaderText="Total Sum" DataFormatString="{0:c}" />
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
            <td class="auto-style22">
                <asp:Label ID="lblMsg" runat="server" style="color: #FFFF00"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content4" runat="server" contentplaceholderid="ContentPlaceHolder5">
                        <asp:Image ID="Image17" runat="server" Height="1175px" ImageUrl="~/Images/General/battlefield_1_soldiers_5k-HD (1).jpg"  Width="480px" ImageAlign="Baseline" style="margin-bottom: 7px" />
                    </asp:Content>
<asp:Content ID="Content5" runat="server" contentplaceholderid="ContentPlaceHolder6">
                        <asp:Image ID="Image18" runat="server" Height="1175px" ImageUrl="~/Images/General/battlefield_1_soldiers_5k-HD.jpg" style="margin-right: 2px; margin-top: 0px" Width="478px" />
                    </asp:Content>

