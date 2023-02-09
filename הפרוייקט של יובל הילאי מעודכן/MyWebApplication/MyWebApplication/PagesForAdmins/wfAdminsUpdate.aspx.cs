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
    public partial class wfAdminsUpdate : System.Web.UI.Page
    {

     protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ViewAdmins();
        }

        protected void ViewAdmins()
        {
            try
            {
                DataTable dt = Entities.Admin.AdminList();
                gvViewAdmins.DataSource = dt;
                gvViewAdmins.DataBind();
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        protected void gvViewAdmins_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvViewAdmins.EditIndex = e.NewEditIndex;
            ViewAdmins();
        }

        protected void gvViewAdmins_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //ערכים שנועדו לעדכון
            string firstName = ((TextBox)(gvViewAdmins.Rows[e.RowIndex].Cells[1].Controls[0])).Text;
            string lastName = ((TextBox)(gvViewAdmins.Rows[e.RowIndex].Cells[2].Controls[0])).Text;
            string tz = ((TextBox)(gvViewAdmins.Rows[e.RowIndex].Cells[3].Controls[0])).Text;
            string userName = gvViewAdmins.Rows[e.RowIndex].Cells[4].Text;
            string password = gvViewAdmins.Rows[e.RowIndex].Cells[5].Text;
            bool mainAdmin = ((CheckBox)(gvViewAdmins.Rows[e.RowIndex].Cells[7].Controls[0])).Checked;
            //ערך שאינו לעדכון
            int idAdmin = int.Parse(gvViewAdmins.Rows[e.RowIndex].Cells[6].Text);
            //יצירת אובייקט מטיפוס מנהל
            Entities.Admin a = new Entities.Admin();
            a.FirstName = firstName;
            a.LastName = lastName;
            a.TZ = tz;
            a.UserName = userName;
            a.Password = password;
            a.MainAdmin = mainAdmin;
            a.IDAdmin = idAdmin;
            //ביצוע העדכון
            a.Update();
            //סגירת השורה לעדכון ושרטוט הגריד מחדש
            gvViewAdmins.EditIndex = -1;
            ViewAdmins();
        }

        protected void gvViewAdmins_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvViewAdmins.EditIndex = -1;
            ViewAdmins();
        }


    }
}