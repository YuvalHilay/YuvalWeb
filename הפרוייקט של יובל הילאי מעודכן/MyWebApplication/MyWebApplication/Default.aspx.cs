using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }





        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {


            Response.Redirect("~/PagesForVisitors/wfCatalog.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/PagesForVisitors/wfCatalog.aspx");
        }


        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/PagesForVisitors/wfCatalog.aspx");
        }
    }
}