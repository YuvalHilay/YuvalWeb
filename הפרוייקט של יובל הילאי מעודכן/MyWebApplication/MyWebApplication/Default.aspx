<%@ Page Title="" Language="C#" MasterPageFile="~/mpMain.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyWebApplication.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
  
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style15 {
        height: 254px;
            font-size: xx-small;
        }
    .carousel-inner > .item > img,
  .carousel-inner > .item > a > img {
      width: 70%;
      margin: auto;
  }
    #wrapper .element_general_images.des_cat {
    margin-top: 5px;
}
        .pos_0 {
            height: 24px;
            width: 1165px;
        }

        
        button:hover {
    opacity: 0.5;
    filter: alpha(opacity=50); /* For IE8 and earlier */
}
button {
    opacity: 1.0;
    filter: alpha(opacity=100); /* For IE8 and earlier */
}


    </style>
 
    <script>
function bigImg(x) {

x.style.opacity = "0.5";
}

function normalImg(x) {

x.style.opacity = "1.0";
}
</script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <table class="auto-style7" style="height: 716px; margin-top: 0px; ">
        <tr>
            <div class="container">
  <br>
  <div id="myCarousel" class="carousel slide" data-ride="carousel" );" >
    <!-- Indicators -->
     
    <ol class="carousel-indicators">
      <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
      <li data-target="#myCarousel" data-slide-to="1"></li>
      <li data-target="#myCarousel" data-slide-to="2"></li>
      <li data-target="#myCarousel" data-slide-to="3"></li>

      
     
    </ol>

    <!-- Wrapper for slides -->
    <div class="carousel-inner" role="listbox">
      <div class="item active">
        <img src="Images/battlefield-1-game-wallpaper.jpg" alt="NBA2K17" width="460" height="345">
      </div>
              <div class="item">
        <img src="Images/watch-dog2.png" alt="GOW4" width="460" height="345">
      </div>
      <div class="item">
        <img src="Images/gearsofwar4.jpg" alt="BF1" width="460" height="345">
      </div>
    


      <div class="item">
        <img src="Images/fifa23.jpg" alt="I2" width="460" height="345">
      </div>

      
        
 
    </div>
   

    <!-- Left and right controls -->
    <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
      <span class="glyphicon glyphicon-chevron-left" aria-hidden="true" ></span>
      <span class="sr-only">Previous</span>
    </a>
    <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
      <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"> </span>
      <span class="sr-only">Next</span>
    </a>
  </div>

        </tr>
        <tr>

            <td class="auto-style15">
                                            <br />

&nbsp;<asp:ImageButton ID="ImageButton1"  runat="server" Height="330px" ImageUrl="~/Images/icons/PC.jpg"  onmouseover="bigImg(this)" onmouseout="normalImg(this)" Width="385px"  OnClientClick="opacity:0.5" OnClick="ImageButton1_Click" />
 

                                            <asp:ImageButton id="ImageButton2" runat="server" Height="330px" ImageUrl="~/Images/icons/PS3.jpg"  Width="386px" onmouseover="bigImg(this)" onmouseout="normalImg(this)"/>
                                            <asp:ImageButton onmouseover="bigImg(this)" onmouseout="normalImg(this)" id="ImageButton3" runat="server" Height="330px" ImageUrl="~/Images/icons/PS4.jpg" Width="385px" OnClick="ImageButton3_Click" />
                                            <br />
&nbsp;<asp:ImageButton onmouseover="bigImg(this)" onmouseout="normalImg(this)" ID="ImageButton4" runat="server" Height="330px" ImageUrl="~/Images/icons/WII.jpg" Width="385px" />
                                            <asp:ImageButton onmouseover="bigImg(this)" onmouseout="normalImg(this)" id="ImageButton5" runat="server" Height="330px" ImageUrl="~/Images/icons/XBOX360.jpg"  Width="386px" />
            
                                            <asp:ImageButton onmouseover="bigImg(this)" onmouseout="normalImg(this)" id="ImageButton6" runat="server" Height="330px" ImageUrl="~/Images/icons/XBOXONE.jpg" Width="385px" OnClick="ImageButton6_Click" />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <div class="current_element_image image_id_72244 pos_0 ">
                                                <a>
                                                <asp:Image ID="Image27" runat="server" ImageUrl="~/Images/General/cooltext230716557782123.png" />
&nbsp;</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a>
                                                <img src="http://files-ptdpritol.netdna-ssl.com/system/photos/72244/original/55383b912d1a2277e87c9c8716d859ee.png" alt=""></a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            </div>
                                        </td>
        </tr>
    </table>

</asp:Content>


