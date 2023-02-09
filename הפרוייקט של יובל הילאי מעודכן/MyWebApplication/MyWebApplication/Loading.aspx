<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loading.aspx.cs" Inherits="MyWebApplication.Loading" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Redirecting you to the store...</title>
    <meta http-equiv="Refresh" content="5;url=Default.aspx" />
</head>
<body onload="PageLoad()"> 
    <script type="text/javascript">
        var _isInitialLoad = true;
        function PageLoad() {
            if (_isInitialLoad) {
                if (document.getElementById('hdnLoaded').value) {
                    _isInitialLoad = false;
                    setTimeout('__doPostBack(\'= this.btnPageLoad.ClientID % > \' , \' \' );', 100);
                }
            }
        }
    </script>
    <form runat="server">
    <asp:Button ID="btnPageLoad" runat="server" Text="Page Load" 
	OnClick="btnPageLoad_Click"
 Style="display: none" UseSubmitBehavior="false" /> 

<input type="hidden" id="hdnLoaded" runat="server"/>
    <div id="divLoading" runat="server" style="text-align: center">
   <br /><br /><br /><br /> 
   <span style="font-size: 10pt; font-family: Verdana">
                <br />
        <br />
        <br />
        <br />
        <br />
        <br />
   </span>
   <br />
   <img src="Images/General/Loading.gif" /><br />
</div>
        </form>
    </body>
</html>


