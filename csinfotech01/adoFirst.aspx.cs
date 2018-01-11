using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;


public partial class adoFirst : System.Web.UI.Page
{
    //SqlConnection con = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false )
        {
      //      con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            //con.Open();

        }
        
    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        
        cmd.CommandText = "INSERT tbemp VALUES(@eid,@en,@ea,@es)";
        cmd.Parameters.Add("@eid", SqlDbType.Int).Value = Convert.ToInt16(TextBox1.Text);
        cmd.Parameters.Add("@en", SqlDbType.VarChar,50).Value = TextBox2.Text;
        cmd.Parameters.Add("@ea", SqlDbType.VarChar,50).Value = TextBox3.Text;
        cmd.Parameters.Add("@es", SqlDbType.BigInt).Value = Convert.ToInt32(TextBox4.Text);

        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
        {
            if (con.State == ConnectionState.Closed)
            {
                cmd.Connection = con;
                con.Open();
                Console.WriteLine(cmd.ExecuteNonQuery());
            }
        }

        
        cmd.Dispose();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox1.Focus();
    }
}