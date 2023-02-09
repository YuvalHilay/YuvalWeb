using MyWebApplication.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;//עבור קלט פלט
using System.Data.OleDb;
using ClassLibraryLibDoQuerise;
using System.Collections;


namespace MyWebApplication.PagesForAdmins
{
    public partial class Catalog : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            ViewCatalog();
        }
        private void ViewCatalog()
        {
            DataTable dt = Entities.Product.GetAllCatalog();
            gvCatalog.DataSource = dt;
            gvCatalog.DataBind();
        }


        protected void gvCatalog_SelectedIndexChanged1(object sender, EventArgs e)
        {
            int idProduct = int.Parse(gvCatalog.SelectedRow.Cells[1].Text);
            Response.Redirect("wfUpdateProduct.aspx?IDProduct=" + idProduct);
        }
    }
}
