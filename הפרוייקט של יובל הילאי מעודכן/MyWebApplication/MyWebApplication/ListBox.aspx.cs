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


namespace MyWebApplication
{
    public partial class ListBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewCatalog();
            }
        }
        private void ViewCatalog()
        {
            try
            {
                DataTable dt = Product.GetCatalog();
                ListBox1.DataSource = dt;
                ListBox1.DataTextField = "ProductName";
                ListBox1.DataValueField = "IDProduct";
                ListBox1.DataBind();
                ListBox1.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }


        protected void btnAddItem_Click1(object sender, EventArgs e)
        {
            ListBox2.SelectedIndex = -1;
            if (ListBox1.SelectedIndex > -1)
            {
                ListBox2.Items.Add(ListBox1.SelectedItem);
                ListBox1.Items.Remove(ListBox1.SelectedItem);
            }
        }

        protected void btnAddAll_Click1(object sender, EventArgs e)
        {
            ListBox2.SelectedIndex = -1;
            int i = 0;
            while (i < ListBox1.Items.Count)
            {
                if (ListBox1.Items[i].Selected)
                {
                    ListBox2.Items.Add(ListBox1.Items[i]);
                    ListBox1.Items.Remove(ListBox1.Items[i]);

                }
                else i++;
            }
        }

        protected void btnRemoveAll_Click(object sender, EventArgs e)
        {
            ListBox1.SelectedIndex = -1;
            int i = 0;
            while (i < ListBox2.Items.Count)
            {
                if (ListBox2.Items[i].Selected)
                {
                    ListBox1.Items.Add(ListBox2.Items[i]);
                    ListBox2.Items.Remove(ListBox2.Items[i]);

                }
                else i++;
            }
        }


        protected void btnRemoveItem_Click(object sender, EventArgs e)
        {
            ListBox1.SelectedIndex = -1;
            if (ListBox2.SelectedIndex > -1)
            {
                ListBox1.Items.Add(ListBox2.SelectedItem);
                ListBox2.Items.Remove(ListBox2.SelectedItem);
            }

        }
    }
}

    