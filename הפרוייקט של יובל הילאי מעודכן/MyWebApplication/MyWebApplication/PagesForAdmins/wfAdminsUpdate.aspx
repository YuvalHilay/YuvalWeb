<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="wfAdminsUpdate.aspx.cs" Inherits="MyWebApplication.PagesForAdmins.wfAdminsUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style type="text/css">
        .auto-style14 {
            font-size: xx-large;
            height: 20px;
            text-align: center;
            width: 635px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <table class="auto-style7">
        <tr>
            <td class="auto-style14"><strong style="background-color: #FFFF00">רשימת מנהלים</strong></td>
        </tr>
        <tr>
            <td class="auto-style15">
                <asp:GridView ID="gvViewAdmins" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="IDAdmin" Height="695px" Width="1159px" OnRowEditing="gvViewAdmins_RowEditing" OnRowUpdating="gvViewAdmins_RowUpdating" AutoGenerateEditButton="True" OnRowCancelingEdit="gvViewAdmins_RowCancelingEdit">
                    <Columns>
                        <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                        <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                        <asp:BoundField DataField="TZ" HeaderText="TZ" />
                        <asp:BoundField DataField="UserName" HeaderText="User Name" ReadOnly="True" />
                        <asp:BoundField DataField="Password" HeaderText="Password" ReadOnly="True" />
                        <asp:BoundField DataField="IDAdmin" HeaderText="Admin ID" ReadOnly="True" />
                        <asp:CheckBoxField DataField="MainAdmin" Text="IsMainAdmin?" />
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
            <td class="auto-style15">
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

