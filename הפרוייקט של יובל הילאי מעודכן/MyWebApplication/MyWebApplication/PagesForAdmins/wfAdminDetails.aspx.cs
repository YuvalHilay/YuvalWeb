using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MyWebApplication.PagesForAdmins
{
    public partial class wfAdminDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["IDAdmin"] != null)
                ViewState["IDAdmin"] = Request.QueryString["IDAdmin"];
            else ViewState["IDAdmin"] = Session["IDADMIN"];
            if (Request.QueryString["NoMainAdmin"] != null)
            {
                Response.Write("You need higher permission for the following action");
            }
            if (Session["IDADMIN"] == null)
                Response.Redirect("../PagesForVisitors/wfLogin.aspx");

            if (!IsPostBack)
            {
                ViewAdminDetails();
            }
        }
        private void ViewAdminDetails()
        {
            int idAdmin = (int)(Session["IDADMIN"]);
            Entities.Admin c = new Entities.Admin();
            c.IDAdmin = idAdmin;
            DataTable dt = c.GetDetails();
            txtIDAdmin.Text = dt.Rows[0]["IDAdmin"].ToString();
            txtFirstName.Text = dt.Rows[0]["FirstName"].ToString();
            txtLastName.Text = dt.Rows[0]["LastName"].ToString();
            txtTZ.Text = dt.Rows[0]["TZ"].ToString();
            txtUserName.Text = dt.Rows[0]["UserName"].ToString();
            txtPassword.Text = dt.Rows[0]["Password"].ToString();
            txtMainAdmin.Text = dt.Rows[0]["MainAdmin"].ToString();
        }
        protected bool UserNameExist()
        {
            Entities.Admin a = new Entities.Admin();
            a.IDAdmin = int.Parse(Session["IDAdmin"].ToString());
            a.UserName = txtUserName.Text;

            Entities.Client c = new Entities.Client();
            c.UserName = txtUserName.Text;

            if (a.ExistAnotherUserName() == true || c.ExistUserName() == true)
                return true;
            else
                return false;
        }
        protected bool TZExist()
        {
            Entities.Admin a = new Entities.Admin();
            a.IDAdmin = int.Parse(Session["IDAdmin"].ToString());
            a.TZ = txtTZ.Text;
            if (a.ExistAnotherTZ() == true)
                return true;
            else
                return false;
        }


        protected void btnUpdate_Click1(object sender, EventArgs e)
        {
            Entities.Admin a = new Entities.Admin();
            a.IDAdmin = int.Parse(Session["IDAdmin"].ToString());
            a.FirstName = txtFirstName.Text;
            a.LastName = txtLastName.Text;
            a.TZ = txtTZ.Text;
            a.UserName = txtUserName.Text;
            a.Password = txtPassword.Text;
            a.MainAdmin = bool.Parse(txtMainAdmin.Text);
            if (UserNameExist() == false && TZExist() == false)
            {
                a.Update();
                lblMsg.Text = "Your details have been updated!!!";
            }
            else if (TZExist() == false) lblMsg.Text = "Username exists";
            else if (UserNameExist() == false) lblMsg.Text = "TZ exists";
            else lblMsg.Text = "Username and TZ exist";
        }

        protected void btnClear_Click1(object sender, EventArgs e)
        {
            ViewAdminDetails();
            lblMsg.Text = "";
        }
    }
    }
