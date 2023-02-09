using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using ClassLibraryLibDoQuerise;
using System.Collections;

namespace MyWebApplication.PagesForVisitors
{
    public partial class wfRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool UserNameExist()
        {
            Entities.Client c = new Entities.Client();
            c.UserName = txtUserName.Text;
            Entities.Admin a = new Entities.Admin();
            a.UserName = txtUserName.Text;

            if (c.ExistAnotherUserName() == true || a.ExistAnotherUserName() == true)

                return true;
            else

                return false;

        }
        private bool ClientExistByEmail()
        {
            Entities.Client c = new Entities.Client();
            c.Email = txtEmail.Text;
            if (c.ExistAnotherEmail() == true)
                return true;
            else
                return false;


        }
        private void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtMobilePhone.Text = "";
            txtBirthDate.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnRegistration_Click(object sender, EventArgs e)
        {
            Entities.Client c = new Entities.Client();
            c.FirstName = txtFirstName.Text;
            c.LastName = txtLastName.Text;
            c.Address = txtAddress.Text;
            c.Email = txtEmail.Text;
            c.MobilePhone = txtMobilePhone.Text;
            c.BirthDate = DateTime.Parse(txtBirthDate.Text);
            c.UserName = txtUserName.Text;
            c.Password = txtPassword.Text;
            if (UserNameExist() == false && ClientExistByEmail() == false)
            {
                c.Insert();
                Clear();
                lblMsg.Text = "Client successfully registered";

            }
            else if (ClientExistByEmail() == false) lblMsg.Text = "UserName Exsits!";
            else if (UserNameExist() == false) lblMsg.Text = "Email Exists!";
            else lblMsg.Text = "UserName and Email Exists!";


        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            lblMsg.Text = "";
        }


    }
}