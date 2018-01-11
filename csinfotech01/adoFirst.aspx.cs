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
        if (Page.IsPostBack == false)
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
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "UPDATE tbemp set ename = @en, eadd = @ea,esal = @es where empid = @eid";
        cmd.Parameters.Add("@eid", SqlDbType.Int).Value = Convert.ToInt16(TextBox1.Text);
        cmd.Parameters.Add("@en", SqlDbType.VarChar, 50).Value = TextBox2.Text;
        cmd.Parameters.Add("@ea", SqlDbType.VarChar, 50).Value = TextBox3.Text;
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
        Clear_Rec();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "INSERT tbemp VALUES(@eid,@en,@ea,@es)";
        cmd.Parameters.Add("@eid", SqlDbType.Int).Value = Convert.ToInt16(TextBox1.Text);
        cmd.Parameters.Add("@en", SqlDbType.VarChar, 50).Value = TextBox2.Text;
        cmd.Parameters.Add("@ea", SqlDbType.VarChar, 50).Value = TextBox3.Text;
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
        Clear_Rec();
        Display_Rec();
    }

    private void Clear_Rec()
    {
        TextBox3.Text = String.Empty;
        TextBox4.Text = String.Empty;
        TextBox2.Text = String.Empty;
        TextBox1.Text = String.Empty;
        TextBox1.Focus();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Display_Rec();
    }

    private void Display_Rec()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Select * from tbemp";

        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
        {
            if (con.State == ConnectionState.Closed)
            {
                cmd.Connection = con;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ListBox1.DataTextField = "ename";
                ListBox1.DataValueField = "empid";
                ListBox1.DataSource = dr;
                ListBox1.DataBind();
                dr.Close();


            }
        }
        cmd.Dispose();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
        {
            if (con.State == ConnectionState.Closed)
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from tbemp where empid = @eid";
                cmd.Parameters.Add("@eid", SqlDbType.Int).Value = Convert.ToInt16(ListBox1.SelectedValue);
                cmd.Connection = con;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    TextBox1.Text = dr[0].ToString();
                    TextBox2.Text = dr["ename"].ToString();
                    TextBox3.Text = dr["eadd"].ToString();
                    TextBox4.Text = dr["esal"].ToString();
                    dr.Close();
                    

                }
                cmd.Dispose();
            }
        }

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "Delete tbemp where empid = @eid";
        cmd.Parameters.Add("@eid", SqlDbType.Int).Value = Convert.ToInt16(TextBox1.Text);
        

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
        Clear_Rec();
        Display_Rec();
    }
}