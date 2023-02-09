<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="wfOrderDetails.aspx.cs" Inherits="MyWebApplication.PagesForClients.wfOrderDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style type="text/css">
        .auto-style13 {
            height: 190px;
        }
        .auto-style19 {
            font-size: large;
            font-weight: 700;
            color: #00FFFF;
        }
        .auto-style20 {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <table class="auto-style7" style="height: 754px; margin-bottom: 0px;">
    <tr>
        <td style="color: #FFFF00; text-align: center">Order Details</td>
    </tr>
    <tr>
        <td class="auto-style20">
            <asp:GridView ID="gvOrderDetails" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="261px" Width="1159px" DataKeyNames="IdOrder">
                <Columns>
                    <asp:BoundField DataField="IdOrder" HeaderText="IdOrder" />
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="MobilePhone" HeaderText="MobliePhone" />
                    <asp:BoundField DataField="OrderDate" DataFormatString="{0:d}" HeaderText="OrderDate" />
                    <asp:BoundField DataField="IdDeal" HeaderText="IdDeal" />
                    <asp:BoundField DataField="IdDelivery" HeaderText="IdDelivery" />
                    <asp:BoundField DataField="TotalSum" HeaderText="TotalSum" />
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
            <asp:Label ID="lblStatus" runat="server" CssClass="auto-style19"></asp:Label>
            <asp:GridView ID="gvItemsInOrder" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="1159px" Height="266px" style="margin-top: 0px">
                <Columns>
                    <asp:BoundField DataField="IDProduct" HeaderText="Product ID" />
                    <asp:BoundField DataField="ProductName" HeaderText="ProductName" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="NumOfUnits" HeaderText="Num of Units" />
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
            <asp:Label ID="lblMsg" runat="server" style="color: #FFFF00; text-align: center"></asp:Label>
            <br />
            <asp:Button ID="btnOrderDelivery" runat="server" OnClick="btnOrderDelivery_Click" Text="Order Delivery" Visible="False" style="font-style: italic; background-color: #00FFFF" Width="1154px" />
        </td>
    </tr>
    </table>
</asp:Content>
