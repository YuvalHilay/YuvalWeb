<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="wfPayment.aspx.cs" Inherits="MyWebApplication.PagesForClients.wfPayment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style type="text/css">
        .auto-style14 {
            height: 18px;
            text-align: center;
            color: #FFFF00;
        }
    .auto-style15 {
        height: 20px;
            color: #FFFF00;
        }
        .auto-style16 {
            height: 20px;
        }
        .auto-style17 {
            height: 20px;
            color: #FFFF00;
            width: 534px;
        }
        .auto-style18 {}
        .auto-style19 {
            text-align: center;
        }
        .auto-style20 {
            height: 82px;
        }
        .auto-style21 {
            text-decoration: underline;
            font-size: xx-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <table class="auto-style7" style="height: 714px">
        <tr>
            <td style="text-align: center; color: #FFFF00;" class="auto-style21"><strong>עמוד הזמנה</strong></td>
        </tr>
        <tr>
            <td class="auto-style14">פרטי לקוח</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="gvClientDetails" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Width="1164px">
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style19" style="color: #FFFF00">פרטי העגלה</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="gvViewCart" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Height="128px" Width="1163px">
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="color: #FFFF00" class="auto-style19">Total Sum:
                <asp:Label ID="lblTotalSum" runat="server" style="color: #FFFFFF"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <table class="auto-style7" style="height: 149px">
                    <tr>
                        <td class="auto-style17">Card Num:</td>
                        <td class="auto-style15">
                            <asp:TextBox ID="txtCardNum" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style17">TZ:</td>
                        <td class="auto-style15">
                            <asp:TextBox ID="txtTZ" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="color: #FFFF00" class="auto-style18">Company Name:</td>
                        <td>
                            <asp:DropDownList ID="ddlCompanies" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td style="color: #FFFF00" class="auto-style18">Expire Month:</td>
                        <td>
                            <asp:DropDownList ID="ddlMonth" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style17">Expire Year:</td>
                        <td class="auto-style15">
                            <asp:DropDownList ID="ddlExpireYear" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style20" colspan="2">
                            <asp:Button ID="btnPay" runat="server" Text="Pay" OnClick="btnPay_Click" style="text-align: center" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:Label ID="lblMsg" runat="server" style="color: #FFFF00; text-align: center"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>


