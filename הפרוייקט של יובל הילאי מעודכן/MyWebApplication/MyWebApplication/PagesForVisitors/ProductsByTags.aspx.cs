using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using ClassLibraryLibDoQuerise;
using System.Collections;
using System.Web.UI.WebControls;

namespace MyWebApplication.PagesForVisitors
{
    public partial class ProductsByTags : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                PopgvAllTags();
        }


        protected void PopgvAllTags() //Populates gvAllTags
        {
    
          
            Entities.Tag t = new Entities.Tag();
     
               DataTable dt = t.GetAllTags();
                gvAllTags.DataSource = dt; // מקור הנתונים של הגריד וויו הוא הטבלה
                gvAllTags.DataBind(); // כריכת נתונים  = תיאום מספר שורות ועמודות בגריד וויו לפי טבלת הנתונים שהתקבלה
    
            
              
            
        }


        protected void PopgvProductsByTag() //Populates gvProductsByTag
        {
           Entities.Product p = new Entities.Product ();
         
           
            p.Tag = tbxTag.Text;
            DataTable dt = p.GetProductsByTag();

            gvProductsByTag.DataSource = dt; // מקור הנתונים של הגריד וויו הוא הטבלה
            gvProductsByTag.DataBind(); // כריכת נתונים  = תיאום מספר שורות ועמודות בגריד וויו לפי טבלת הנתונים שהתקבלה
            //}
            //catch (Exception ex)
            //{
            //    lblMsg.Text = ex.Message;
            //}
            Response.Write(p.Tag);
            gvProductsByTag.Visible = true;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            gvProductsByTag.Visible = true;
            gvAllTags.Visible = false;
            PopgvProductsByTag();
        }

        protected void gvAllTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvAllTags.SelectedRow;
            tbxTag.Text = row.Cells[1].Text.Trim('#');

        }

        protected void btnChooseNewTag_Click(object sender, EventArgs e)
        {
            gvAllTags.Visible = true;
            gvProductsByTag.Visible = false;
            if (gvAllTags.SelectedIndex != -1)//לוודא שקיימת שורה ב"בחירה"..
                gvAllTags.SelectedRow.RowState = DataControlRowState.Normal;
        }

        protected void gvProductsByTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idProduct = int.Parse(gvProductsByTag.SelectedDataKey.Value.ToString());
            Response.Redirect("wfProductPage.aspx?IDPRODUCT=" + idProduct);
        }
    }
}