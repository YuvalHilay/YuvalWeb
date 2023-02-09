using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApplication
{
    public partial class wfCalc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ProxyCalc.CalcService serviceCalc = new ProxyCalc.CalcService();
            lblResult.Text = serviceCalc.Add(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text)).ToString();
            // lblResult.Text = 
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            ProxyCalc.CalcService serviceCalc = new ProxyCalc.CalcService();
            lblResult.Text = serviceCalc.Sub(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text)).ToString();
        }

        protected void Cefel_Click(object sender, EventArgs e)
        {
            ProxyCalc.CalcService serviceCalc = new ProxyCalc.CalcService();
            lblResult.Text = serviceCalc.Cefel(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text)).ToString();
        }
        protected void Hilok_Click(object sender, EventArgs e)
        {
            ProxyCalc.CalcService serviceCalc = new ProxyCalc.CalcService();
            lblResult.Text = serviceCalc.Hilok(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text)).ToString();
        }
        }

    }
