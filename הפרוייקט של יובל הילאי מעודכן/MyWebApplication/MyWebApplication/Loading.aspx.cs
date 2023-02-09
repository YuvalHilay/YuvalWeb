using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace MyWebApplication
{
    public partial class Loading : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnPageLoad_Click(object sender, EventArgs e)
        {
            hdnLoaded.Value = "true";
            divLoading.Visible = false;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content = "5;url=Loading.aspx";
            this.Page.Controls.Add(meta);
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.AppendHeader("Refresh", "5;url=Loading.aspx");
        }
    }
}