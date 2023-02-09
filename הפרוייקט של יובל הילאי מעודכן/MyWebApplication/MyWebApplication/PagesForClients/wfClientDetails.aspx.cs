using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MyWebApplication.PagesForClients
{
    public partial class wfClientDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IDCLIENT"] == null)
                Response.Redirect("../PagesForVisitors/wfLogin.aspx");

            if (!IsPostBack)
            {
                ViewClientDetails();
            }
        }

        private void ViewClientDetails()
        {
            int idClient = (int)(Session["IDCLIENT"]);
            Entities.Client c = new Entities.Client();
            c.IDClient = idClient;
            DataTable dt = c.GetDetails();
            txtIdClient.Text = dt.Rows[0]["IdClient"].ToString();
            txtFirstName.Text = dt.Rows[0]["FirstName"].ToString();
            txtLastName.Text = dt.Rows[0]["LastName"].ToString();
            txtAddress.Text = dt.Rows[0]["Address"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtMobilePhone.Text = dt.Rows[0]["MobilePhone"].ToString();
            txtBirthDate.Text = ((DateTime)dt.Rows[0]["Birthdate"]).ToShortDateString();
            txtUserName.Text = dt.Rows[0]["UserName"].ToString();
            txtPassword.Text = dt.Rows[0]["Password"].ToString();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Entities.Client c = new Entities.Client();
            c.IDClient = int.Parse(Session["IDClient"].ToString());
            c.FirstName = txtFirstName.Text;
            c.LastName = txtLastName.Text;
            c.Address = txtAddress.Text;
            c.Email = txtEmail.Text;
            c.MobilePhone = txtMobilePhone.Text;
            c.BirthDate = DateTime.Parse(txtBirthDate.Text);
            c.UserName = txtUserName.Text;
            c.Password = txtPassword.Text;

            if (UserNameExist() == false && EmailExist() == false)
            {
                c.Update();
                lblMsg.Text = "Your details have been updated!!!";
            }
            else
                lblMsg.Text = "Username or Email exsists.";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ViewClientDetails();
            lblMsg.Text = "";
        }
        protected bool UserNameExist()
        {
            Entities.Client c = new Entities.Client();
            c.IDClient = int.Parse(Session["IDClient"].ToString());
            c.UserName = txtUserName.Text;

            Entities.Admin a = new Entities.Admin();
            a.UserName = txtUserName.Text;

            if (c.ExistAnotherUserName() == true || a.ExistUserName() == true)
                return true;
            else
                return false;
        }
        protected bool EmailExist()
        {
            Entities.Client c = new Entities.Client();
            c.IDClient = int.Parse(Session["IDClient"].ToString());
            c.Email = txtEmail.Text;
            if (c.ExistAnotherEmail() == true)
                return true;
            else
                return false;
        }



    }
}