using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApplication.PagesForVisitors
{
    public partial class Categories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void dlCategories_ItemCommand(object source, DataListCommandEventArgs e)
        {
            string idCategory = ((HiddenField)e.Item.FindControl("HiddenField1")).Value;
            Response.Redirect("wfProductsByCategory.aspx?IdCategory=" + idCategory);
        }
    }
}