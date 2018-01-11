using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack == true)
        Label1.Text = DateTime.Now.ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void MethodForButtons(object sender, EventArgs e)
    {
        if (sender == Button2)
        {
            TextBox3.Text = (Convert.ToInt16(TextBox1.Text) + Convert.ToInt16(TextBox2.Text)).ToString();
        }
        else if (sender == Button3)
        {
            TextBox3.Text = (Convert.ToInt16(TextBox1.Text) - Convert.ToInt16(TextBox2.Text)).ToString();
        }
        else if(sender == Button4)
        {
            TextBox3.Text = (Convert.ToInt16(TextBox1.Text) * Convert.ToInt16(TextBox2.Text)).ToString();
        }
        else if (sender == Button5)
        {
            TextBox3.Text = (Convert.ToInt16(TextBox1.Text) / Convert.ToInt16(TextBox2.Text)).ToString();
        }
        else if (sender == Button6)
        {
            TextBox3.Text = (Convert.ToInt16(TextBox1.Text) % Convert.ToInt16(TextBox2.Text)).ToString();
        }



    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");
    }
}