using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Project
{
    public partial class Contactus1 : System.Web.UI.Page
    {
        DataClasses1DataContext db=new DataClasses1DataContext();
        Table tb=new Table();
        static bool addition = false;
        static decimal storevalue;

        protected void Page_Load(object sender, EventArgs e)
        {
         
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "500";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "600";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "450";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "550";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "650";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "750";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "550";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "650";
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "750";
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "850";
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "500";
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "350";
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "600";
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "600";
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "600";
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "600";
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "600";
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "600";
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "600";
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "600";
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "600";
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "600";
        }

        protected void Button23_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "600";
        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "600";
        }

        protected void Button25_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "450";
        }

        protected void Button26_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "350";
        }

        protected void Button27_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "350";
        }

        protected void Button28_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "450";
        }

        protected void Button29_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "350";
        }

        protected void Button30_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "350";
        }

        protected void Button31_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "250";
        }

        protected void Button32_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "440";
        }

        protected void Button33_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "550";
        }

        protected void Button34_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "750";
        }

        protected void Button35_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "950";
        }

        protected void Button36_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "50";
        }

        protected void Button37_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "350";
        }

        protected void Button38_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "150";
        }

        protected void Button39_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "550";
        }

        protected void Button40_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "550";
        }

        protected void Button41_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "750";
        }

        protected void Button42_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "550";
        }

        protected void Button43_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "850";
        }

        protected void Button44_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "750";
        }

        protected void Button45_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "650";
        }

        protected void Button46_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "750";
        }

        protected void Button47_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "1500";
        }

        protected void Button48_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "450";
        }

        protected void Button49_Click(object sender, EventArgs e)
        {
            TextBox2.Text += "450";
        }

        protected void Button50_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                addition = false;
                Response.Write("Textbox Empty");
            }
            else
            {
                addition = true;
                storevalue = Convert.ToDecimal(TextBox2.Text);
                TextBox2.Text = "";
            }

        }

        protected void Button52_Click(object sender, EventArgs e)
        {
            decimal result_calculate;
            if (addition == true)
            {
                result_calculate = storevalue + Convert.ToDecimal(TextBox2.Text);
                TextBox2.Text = result_calculate.ToString();
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button53_Click(object sender, EventArgs e)
        {
            tb.Name = TextBox3.Text;
            tb.Number = Convert.ToInt32(TextBox4.Text);
            tb.Email = TextBox5.Text;
            tb.Bill = Convert.ToInt32(TextBox2.Text);
            db.Tables.InsertOnSubmit(tb);
            db.SubmitChanges();
        }
    }
}