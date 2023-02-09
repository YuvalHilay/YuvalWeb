<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="wfAdminDetails.aspx.cs" Inherits="MyWebApplication.PagesForAdmins.wfAdminDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style type="text/css">

    .auto-style19 {
        color: #00FFFF;
        font-size: xx-large;
    }
        .auto-style20 {
            height: 20px;
            color: #FFFF00;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <table class="auto-style7" style="height: 748px; width: 1144px">
        <tr>
            <td style="color: #FFFF00">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<span class="auto-style19"><strong>Personal area </strong></span>
            <br />
            <br />
            (Admin Details)</td>
        </tr>
        <tr>
            <td>
                <table class="auto-style7" style="height: 643px">
                    <tr>
                        <td style="color: #FFFF00">Admin Id:</td>
                        <td>
                            <asp:TextBox ID="txtIDAdmin" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="color: #FFFF00">First Name:</td>
                        <td>
                            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style20">Last Name:</td>
                        <td class="auto-style20">
                            <br />
                            <br />
                            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td style="color: #FFFF00">Tz:</td>
                        <td>
                            <asp:TextBox ID="txtTZ" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="color: #FFFF00">User Name:</td>
                        <td>
                            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="color: #FFFF00">Password:</td>
                        <td>
                            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="color: #FFFF00">Main Admin:</td>
                        <td>
                            <asp:TextBox ID="txtMainAdmin" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click1" Text="Update" />
                        </td>
                        <td>
                            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click1" Text="Clear" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">
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

