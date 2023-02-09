using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApplication.PagesForVisitors
{
    public partial class wfManufacturers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void dlManufacturers_ItemCommand(object source, DataListCommandEventArgs e)
        {
            string idManufacturer = ((HiddenField)e.Item.FindControl("HiddenField1")).Value;
            Response.Redirect("wfProductsByManufacturers.aspx?IdManufacturer=" + idManufacturer);

       
        }
    }
}