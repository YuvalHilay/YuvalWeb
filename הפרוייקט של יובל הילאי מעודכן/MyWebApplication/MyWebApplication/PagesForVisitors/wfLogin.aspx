<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="wfLogin.aspx.cs" Inherits="MyWebApplication.wfLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style type="text/css">
        .auto-style9 {
            height: 20px;
        }
        .auto-style13 {
            height: 513px;
            width: 1166px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <table class="auto-style7" style="height: 710px">
        <tr>
            <td class="auto-style13">
                <asp:Login ID="Login1" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderPadding="4" BorderStyle="Solid" BorderWidth="5px" Font-Names="Verdana" Font-Size="1.8em" ForeColor="#333333" OnAuthenticate="Login1_Authenticate" Height="651px" Width="1138px" style="margin-bottom: 0px">
                    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                    <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="1.3em" ForeColor="#284E98" />
                    <TextBoxStyle Font-Size="1.8em" />
                    <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="1.8em" ForeColor="White" />
                </asp:Login>
                <asp:Button ID="btnRegistration" runat="server" BackColor="#CCFF33" BorderColor="#FFFFCC" Font-Size="X-Large" Height="49px" OnClick="btnRegistration_Click" Text="! עדיין לא נרשמת ? לחץ כאן  " Width="1156px" />
            </td>
        </tr>
        </table>
</asp:Content>
<asp:Content ID="Content4" runat="server" contentplaceholderid="ContentPlaceHolder6">
                        <asp:Image ID="Image18" runat="server" Height="1153px" ImageUrl="~/Images/General/battlefield_1_soldiers_5k-HD.jpg" style="margin-right: 2px; margin-top: 0px" Width="478px" />
                    </asp:Content>

<asp:Content ID="Content5" runat="server" contentplaceholderid="ContentPlaceHolder5">
                        <asp:Image ID="Image17" runat="server" Height="1155px" ImageUrl="~/Images/General/battlefield_1_soldiers_5k-HD (1).jpg"  Width="480px" ImageAlign="Baseline" style="margin-bottom: 7px" />
                    </asp:Content>


