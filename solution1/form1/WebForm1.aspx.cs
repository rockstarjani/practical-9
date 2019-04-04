using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace form1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        calc.WebService1 inst1 = new calc.WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void subtbtn_Click(object sender, EventArgs e)
        {
            lbl1.Text = inst1.Subtract(Convert.ToInt16(txt1.Text), Convert.ToInt16(txt2.Text)).ToString();
        }


        protected void addbtn_Click(object sender, EventArgs e)
        {
            lbl1.Text = inst1.Add(Convert.ToInt16(txt1.Text), Convert.ToInt16(txt2.Text)).ToString();
        }

        protected void mulbtn_Click(object sender, EventArgs e)
        {
            lbl1.Text = inst1.Multiply(Convert.ToInt16(txt1.Text), Convert.ToInt16(txt2.Text)).ToString();
        }

        protected void divbtn_Click(object sender, EventArgs e)
        {
            lbl1.Text = inst1.Divide(Convert.ToInt16(txt1.Text), Convert.ToInt16(txt2.Text)).ToString();
        }
    }
}