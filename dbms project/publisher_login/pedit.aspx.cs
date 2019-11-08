using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dbms_project.publisher_login
{
    public partial class pedit : System.Web.UI.Page
    {
        string n, p, s,name;
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\Archit\source\repos\dbms project\dbms project\App_Data\mydata.mdf;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        {
            name = Session["search"].ToString();
            Label3.Text = "name";
            Label4.Text = "size";
            Label5.Text = "price";
            string result1 = "select game_name from games where game_name=@u and publisher=@p";
            SqlCommand showresult1 = new SqlCommand(result1, con);
            showresult1.Parameters.AddWithValue("@u",name);
            showresult1.Parameters.AddWithValue("@p", Session["add"].ToString());
            con.Open();
              n = Label10.Text = showresult1.ExecuteScalar().ToString();


            string result2 = "select size from games where game_name=@u and publisher=@p";
            SqlCommand showresult2 = new SqlCommand(result2, con);
            showresult2.Parameters.AddWithValue("@u", name);
            showresult2.Parameters.AddWithValue("@p", Session["add"].ToString());

            s = Label11.Text = showresult2.ExecuteScalar().ToString();


            string result3 = "select price from games where game_name=@u and publisher=@p";
            SqlCommand showresult3 = new SqlCommand(result3, con);
            showresult3.Parameters.AddWithValue("@u", name);
            showresult3.Parameters.AddWithValue("@p", Session["add"].ToString());

            p = Label12.Text = showresult3.ExecuteScalar().ToString();

            SqlCommand cmd = new SqlCommand("select img from games where game_name=@u and publisher=@p", con);
          cmd.Parameters.AddWithValue("@u", name);
            cmd.Parameters.AddWithValue("@p", Session["add"].ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();

            TextBox1.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            Button4.Visible = false;
            Button5.Visible = false;
            Button6.Visible = false;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Visible = true;
            Button4.Visible = true;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Visible = true;
            Button5.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox3.Visible = true;
            Button6.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Label16.Text = "No value is entered";
            }
            else
            {
                string result = "update games set game_name=@n where game_name=@a and publisher=@b";
                SqlCommand showresult = new SqlCommand(result, con);
                showresult.Parameters.AddWithValue("@n", TextBox1.Text.ToString());
                showresult.Parameters.AddWithValue("@a", Session["search"].ToString());
                showresult.Parameters.AddWithValue("@b", Session["add"].ToString());
                con.Open();
                showresult.ExecuteNonQuery();
                con.Close();
                string result1 = "select game_name from games where game_name=@u and publisher=@p";
                SqlCommand showresult1 = new SqlCommand(result1, con);
                showresult1.Parameters.AddWithValue("@u", TextBox1.Text.ToString());
                showresult1.Parameters.AddWithValue("@p", Session["add"].ToString());
                con.Open();
                Label10.Text = showresult1.ExecuteScalar().ToString();
                con.Close();
                Button4.Visible = false;
                Session["search"] = TextBox1.Text.ToString();
                TextBox1.Text = "";
                TextBox1.Visible = false;

            }

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == null)
            {
                Label16.Text = "No value is entered";
            }
            else
            {
                string result = "update games set price=@n where game_name=@a and publisher=@b";
                SqlCommand showresult = new SqlCommand(result, con);
                showresult.Parameters.AddWithValue("@n", TextBox3.Text.ToString());
                showresult.Parameters.AddWithValue("@a", name);
                showresult.Parameters.AddWithValue("@b", Session["add"].ToString());
                con.Open();
                showresult.ExecuteNonQuery();
                con.Close();
                string result1 = "select price from games where game_name=@u and publisher=@p";
                SqlCommand showresult1 = new SqlCommand(result1, con);
                showresult1.Parameters.AddWithValue("@u", name);
                showresult1.Parameters.AddWithValue("@p", Session["add"].ToString());
                con.Open();
                Label12.Text = showresult1.ExecuteScalar().ToString();
                con.Close();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text == null)
            {
                Label16.Text = "No value is entered";
            }
            else
            {
                string result = "update games set size =@n where game_name=@a and publisher=@b";
                SqlCommand showresult = new SqlCommand(result, con);
                showresult.Parameters.AddWithValue("@n", TextBox2.Text.ToString ());
                showresult.Parameters.AddWithValue("@a",name);
                showresult.Parameters.AddWithValue("@b", Session["add"].ToString());
                con.Open();
                showresult.ExecuteNonQuery();
                con.Close();
                string result1 = "select size from games where game_name=@u and publisher=@p";
                SqlCommand showresult1 = new SqlCommand(result1, con);
                showresult1.Parameters.AddWithValue("@u", name);
                showresult1.Parameters.AddWithValue("@p", Session["add"].ToString());
                con.Open();
                Label11.Text = showresult1.ExecuteScalar().ToString();
                con.Close();
            }

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/publisher_login/pdashbord.aspx");
        }

    }
}