<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="wfRegistration.aspx.cs" Inherits="MyWebApplication.PagesForVisitors.wfRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style type="text/css">
    .auto-style14 {
        height: 20px;
    }
    .auto-style16 {
        color: #FFFF00;
            height: 15px;
        }
    .auto-style17 {
        margin-left: 0px;
            font-size: xx-large;
            background-color: #FF0000;
        }
        .auto-style18 {
            height: 20px;
            color: #000000;
            font-size: xx-large;
            text-align: center;
            background-color: #99FF66;
        }
        .auto-style22 {
            height: 12px;
            width: 326px;
            color: #FFFF00;
            font-size: large;
        }
        .auto-style23 {
            height: 12px;
        }
        .auto-style24 {
            height: 6px;
            width: 326px;
            color: #FFFF00;
            font-size: large;
        }
        .auto-style25 {
            height: 6px;
        }
        .auto-style26 {
            height: 18px;
            width: 326px;
            color: #FFFF00;
            font-size: large;
        }
        .auto-style27 {
            height: 18px;
        }
        .auto-style31 {
            height: 11px;
            width: 326px;
            color: #FFFF00;
            font-size: large;
        }
        .auto-style33 {
            height: 13px;
            width: 326px;
            color: #FFFF00;
            font-size: large;
        }
        .auto-style34 {
            height: 13px;
        }
        .auto-style35 {
            height: 11px;
        }
        .auto-style36 {
            height: 20px;
            width: 326px;
            color: #FFFF00;
            font-size: large;
        }
        .auto-style37 {
            height: 17px;
            width: 326px;
            color: #FFFF00;
            font-size: large;
        }
        .auto-style38 {
            height: 17px;
        }
        .auto-style40 {
            background-color: #99FF66;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">

    <table class="auto-style7" style="height: 1028px">
    <tr>
        <td class="auto-style18" colspan="2"><strong><span class="auto-style40">Registration</span></strong></td>
    </tr>
    <tr>
        <td class="auto-style36"><strong>First Name:</strong></td>
        <td class="auto-style14">
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    <tr>
        <td class="auto-style36"><strong>Last Name:</strong></td>
        <td class="auto-style14">
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style26"><strong>Address:</strong></td>
        <td class="auto-style27">
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style24"><strong>Email:</strong></td>
        <td class="auto-style25">
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style22"><strong>Mobile Phone:</strong></td>
        <td class="auto-style23">
            <asp:TextBox ID="txtMobilePhone" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style33"><strong>Birth Date:</strong></td>
        <td class="auto-style34">
            <asp:TextBox ID="txtBirthDate" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style31"><strong>Username:</strong></td>
        <td class="auto-style35">
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    <tr>
        <td class="auto-style37"><strong>Password:</strong></td>
        <td class="auto-style38">
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style16" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnRegistration" runat="server" Text="Registration" OnClick="btnRegistration_Click" style="color: #000000; font-size: xx-large; background-color: #00FF00" Width="447px" />
&nbsp;
            <asp:Button ID="btnClear" runat="server" CssClass="auto-style17" Text="Clear" Width="463px" OnClick="btnClear_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblMsg" runat="server" style="color: #FFFF00"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
