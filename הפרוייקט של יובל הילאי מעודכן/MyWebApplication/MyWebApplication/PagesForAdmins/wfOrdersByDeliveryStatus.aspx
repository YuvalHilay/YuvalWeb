<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="wfOrdersByDeliveryStatus.aspx.cs" Inherits="MyWebApplication.PagesForAdmins.wfOrdersByDeliveryStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style type="text/css">
        .auto-style13 {
            text-align: center;
        }
        .auto-style14 {
            color: #00FFFF;
        }
        .auto-style15 {
            text-align: center;
            color: #00FFFF;
        }
        .auto-style16 {
            color: #00FFFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <p class="auto-style15">
        Orders By Delivery Status</p>
    <p class="auto-style13">
        <span class="auto-style16">Choose Status:</span><span class="auto-style14"> </span>
        <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="True" CssClass="auto-style14" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="0">All orders</asp:ListItem>
            <asp:ListItem Value="-1">Orders without delivery</asp:ListItem>
            <asp:ListItem Value="1">Orders in delivery</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:GridView ID="gvOrders" runat="server" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="IDOrder" Height="565px" OnSelectedIndexChanged="gvOrders_SelectedIndexChanged" style="margin-left: 3px" Width="1091px">
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
    </p>
    <p class="auto-style13">
        <asp:Label ID="lblMsg" runat="server" CssClass="auto-style14" style="direction: ltr"></asp:Label>
    </p>
</asp:Content>
