<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="wfClientDetails.aspx.cs" Inherits="MyWebApplication.PagesForClients.wfClientDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style type="text/css">
    .auto-style11 {
        width: 580px;
    }
    .auto-style12 {
        width: 580px;
        height: 20px;
    }
    .auto-style13 {
            width: 1103px;
            text-align: center;
        }
    .auto-style14 {
            width: 554px;
            height: 26px;
            color: #FFFF00;
        }
    .auto-style15 {
            width: 1103px;
            height: 26px;
        }
    .auto-style16 {
        text-align: center;
            color: #FFFF00;
            height: 749px;
        }
    .auto-style19 {
        color: #660066;
        font-size: xx-large;
    }
    .auto-style21 {
            width: 554px;
            height: 30px;
        }
    .auto-style22 {
            width: 1103px;
            height: 30px;
        }
        .auto-style24 {
            width: 554px;
            color: #FFFF00;
        }
        .auto-style31 {
            width: 1103px;
            font-size: xx-large;
            color: #000000;
            height: 26px;
        }
        .auto-style32 {
            width: 1103px;
            font-size: xx-large;
            color: #000000;
            }
        .auto-style34 {
            width: 1103px;
        }
        .auto-style29 {
            margin-left: 0px;
            margin-bottom: 3px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <table class="auto-style7" style="height: 751px; width: 1140px">
    <tr>
        <td class="auto-style16">&nbsp;&nbsp;&nbsp;<span class="auto-style19"><strong>Personal area 
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            </strong></span>
            <br />
            <table style="height: 662px; margin-top: 0px; margin-bottom: 13px">
                <tr>
                    <td class="auto-style14">Client Id:</td>
                    <td class="auto-style31">
                        <asp:TextBox ID="txtIdClient" runat="server"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style24">First Name:</td>
                    <td class="auto-style34">
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style24">Last Name:</td>
                    <td class="auto-style34">
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style24">Address:</td>
                    <td class="auto-style34">
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style24">Email:</td>
                    <td class="auto-style34">
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style24">Mobile Phone:</td>
                    <td class="auto-style32">
                        <asp:TextBox ID="txtMobilePhone" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style24">Your Birthday:</td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtBirthDate" runat="server" CssClass="auto-style29" Width="122px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style14">Username:<br />
                    </td>
                    <td class="auto-style15">
                        <br />
                        <asp:TextBox ID="txtUserName" runat="server" style="text-align: center"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style14">Password:</td>
                    <td class="auto-style15">
                        <br />
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21"></td>
                    <td class="auto-style22"></td>
                </tr>
                <tr>
                    <td class="auto-style21">
                        <asp:Button ID="Update" runat="server" Text="Update" Height="26px" style="color: #000000; background-color: #00FF00" Width="529px" />
                    </td>
                    <td class="auto-style22">
                        <asp:Button ID="Clear" runat="server" Text="Clear" style="color: #000000; background-color: #FF0000" Width="593px" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="lblMsg" runat="server" style="text-align: center; color: #FFFF00;"></asp:Label>
        </td>
    </tr>
    </table>
</asp:Content>
