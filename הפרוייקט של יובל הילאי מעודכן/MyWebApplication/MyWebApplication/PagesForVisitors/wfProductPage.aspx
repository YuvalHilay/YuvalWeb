<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="wfProductPage.aspx.cs" Inherits="MyWebApplication.PagesForVisitors.wfProductPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style type="text/css">
        .auto-style16 {
        height: 123px;
    }
        #divRateCnt {
    width: 130px;
    position: relative;
}

#divRareCnt, #divStarsCnt{
    height: 26px;
    background: url(http://s4.postimg.org/wi683zp2h/stars.png) 0 0px repeat-x;
}

#divRateCnt input{
    display: none;
}

#divRateCnt label{
    display: none;
    position: absolute;
    top: 0;
    left: 0;
    height: 26px;
    width: 130px;
    cursor: pointer;
}
#divRateCnt:hover label{
    display: block;
}
#divRateCnt label:hover{
    background: url(http://s4.postimg.org/wi683zp2h/stars.png) 0 -52px repeat-x;
}

#divRateCnt label + input + label{width: 104px;}
#divRateCnt label + input + label + input + label{width: 78px;}
#divRateCnt label + input + label + input + label + input + label{width: 52px;}
#divRateCnt label + input + label + input + label + input + label + input + label{width: 26px;}

#divRateCnt input:checked + label{
    display: block;
    background: url(http://s4.postimg.org/wi683zp2h/stars.png) 0 -52px repeat-x;
}

        .auto-style17 {
            height: 146px;
        }
        .auto-style18 {
            height: 62px;
            color: #FFFF00;
            font-size: xx-large;
        }
        .auto-style19 {
            height: 21px;
        }
        .auto-style20 {
            height: 98px;
            color: #FFFF00;
            font-size: xx-large;
        }
        .auto-style22 {
            height: 115px;
        }
        .auto-style23 {
            height: 14px;
        }
        .auto-style24 {
            height: 33px;
        }
        .auto-style25 {
            height: 115px;
            color: #FFFF00;
        }
        .auto-style15 {
            color: #FFFF00;
        }
        .auto-style26 {
            font-size: xx-large;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <table class="auto-style7" style="height: 667px">
        <tr>
            <td class="auto-style19"><strong style="color: #00FFFF">עמוד מוצר</strong></td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:GridView ID="gvProductDetails" runat="server" CellPadding="3" Height="364px" Width="1156px" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
                    <Columns>
                        <asp:BoundField DataField="IDProduct" HeaderText="קוד מוצר" />
                        <asp:BoundField DataField="ProductName" HeaderText="שם מוצר" />
                        <asp:BoundField DataField="ProductDescription" HeaderText="תיאור מוצר" />
                        <asp:ImageField DataImageUrlField="ProductImage" DataImageUrlFormatString="~/Images/Products/{0}" HeaderText="תמונת מוצר">
                            <ControlStyle Height="150px" />
                        </asp:ImageField>
                        <asp:BoundField DataField="Price" HeaderText="מחיר המוצר" DataFormatString="{0:c}" />
                        <asp:ImageField DataImageUrlField="ManufacturerLogo" DataImageUrlFormatString="~/Images/Manufacturers/{0}" HeaderText="לוגו היצרן">
                            <ControlStyle Height="150px" />
                        </asp:ImageField>
                        <asp:ImageField DataImageUrlField="CategoryLogo" DataImageUrlFormatString="~/Images/Categories/{0}" HeaderText="לוגו הקטגוריה">
                            <ControlStyle Height="150px" />
                        </asp:ImageField>
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
            <td class="auto-style17">
                <br />
                <asp:Image ID="imgPicture" runat="server" Height="96px" Width="137px" />
                <span class="auto-style20"><strong>:הגבלת גיל</strong></span><br />
                <span class="auto-style18"><strong>:דרישות<br />
                <asp:Label ID="txtReq" runat="server" style="font-weight: 700; color: #00FF00" CssClass="auto-style26"></asp:Label>
                <br />
                </strong></span><br />
                <asp:Label ID="lblMsg" runat="server" CssClass="auto-style15"></asp:Label>
                <br />
<input type="hidden" value="0,0,0,0,0" id="res" />
 <div id="divRateCnt">
  <div id="divStarsCnt"></div>
  <input type="radio" name="rating" id="star5" value="5" onchange="showme(this);"><label for="star5"></label>
  <input type="radio" name="rating" id="star4" value="4" onchange="showme(this);"><label for="star4"></label>
  <input type="radio" name="rating" id="star3" value="3" onchange="showme(this);"><label for="star3"></label>
  <input type="radio" name="rating" id="star2" value="2" onchange="showme(this);"><label for="star2"></label>
  <input type="radio" name="rating" id="star1" value="1" onchange="showme(this);"><label for="star1"></label>
 </div>
 <br class="auto-style22">
 <span id="result"></span>
 <br class="auto-style22"><br class="auto-style22">
                <span class="auto-style25">Total vote(s) :</span><br class="auto-style22">
 <div style="width:130px;height:26px;background:url(http://s4.postimg.org/wi683zp2h/stars.png) 0 0 repeat-x;position:relative;">
  <div id="bar" style="width:130px;height:26px;background:url(http://s4.postimg.org/wi683zp2h/stars.png) 0 -26px repeat-x;position:absolute;top:0;left:0;width:0%;"></div>
 </div>
 <span id="sta"></span>

            </td>
        </tr>
        <tr>
            <td class="auto-style23">
                <asp:DropDownList ID="ddlNumUnits" runat="server" Height="24px" style="text-align: right" Width="142px">
                    <asp:ListItem Selected="True">1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style24">
                <asp:Button ID="btnAddToCart" runat="server" Height="58px" OnClick="btnAddToCart_Click" Text="Add To Cart" Width="305px" />
            </td>
        </tr>
    </table>
  <script>
function showme(id) {
    document.getElementById('result').innerHTML = 'My vote : '+id.value;
    var r = document.getElementById('res').value.split(',');
    var s='';
    for(var i=0;i<5;i++) {
      if(id.value==(i+1).toString()) {
        var x = parseInt(r[i])+1;
        r[i]=x.toString();
      }
      if(i==4) {s+=r[i];} else {s+=r[i]+',';}
    }
    document.getElementById('res').value=s;
    calc();
  }
  function calc() {
    var x=document.getElementById('res').value.split(',');
    var r=0;
    var t=0;
    for(var i=0;i<5;i++) {
      t+=parseInt(x[i]);
      r+=(parseInt(x[i])*(i+1));
    }
    var s=parseInt((r/t)*20);
    document.getElementById('bar').style.width=s.toString()+'%';
    document.getElementById('sta').innerHTML=s.toString()+'%';
  }

  </script>
</asp:Content>
