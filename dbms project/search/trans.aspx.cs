using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dbms_project.search
{
    public partial class trans : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\Archit\source\repos\dbms project\dbms project\App_Data\mydata.mdf;Integrated Security=True;MultipleActiveResultSets=true");
       
        protected void Page_Load(object sender, EventArgs e)
        {
            string st= Session["result"].ToString();
            Label3.Text = st;
            Label1.Text = Session["val2"].ToString();
            Label6.Text = Label1.Text;
            con.Open();
            string q = Session["val2"].ToString();
            SqlCommand cmd7 = new SqlCommand("select * from games WHERE game_name = '" + q + "' ", con);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            GridView1.DataSource = dr7;
            GridView1.DataBind();
            GridView2.DataSource = dr7;  /////not working?
            GridView2.DataBind();
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("num", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@user", Session["result"].ToString());
            SqlParameter p2 = new SqlParameter("@password", TextBox2.Text);
            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            con.Open();
            string rd = com.ExecuteScalar().ToString();
            int myInt = 1;
            string check = myInt.ToString();
            con.Close();

            if (String.Equals(rd,check))
            {
                
                string result = "SELECT user_id FROM[user] WHERE[user] = '" + Session["result"].ToString() + "'";
                SqlCommand showresult = new SqlCommand(result, con);
                con.Open();
                string u= showresult.ExecuteScalar().ToString();

                string result1 = "SELECT game_id FROM [games] WHERE[game_name] = '" + Session["game"].ToString() + "'";
                SqlCommand showresult1 = new SqlCommand(result1, con);

                string g = showresult1.ExecuteScalar().ToString();

                string result2 = "SELECT price FROM [games] WHERE [game_name]='" + Session["game"].ToString() + "'";
                SqlCommand showresult2 = new SqlCommand(result2, con);

                string a= showresult2.ExecuteScalar().ToString();

                string result3 = "SELECT user_id FROM [user] WHERE [user]='" + Session["result"].ToString() + "'";
                SqlCommand showresult3 = new SqlCommand(result3, con);

               string d = DateTime.Now.ToString("yyyy-MM-dd");

                string c = TextBox3.Text;

                SqlCommand cmd = new SqlCommand("insert into [dbo].[payment] values (@d,@u,@g, @a,@c )", con);
                cmd.Parameters.AddWithValue("@d", DateTime.Now);
                cmd.Parameters.AddWithValue("@u",u);
                cmd.Parameters.AddWithValue("@g",g);
                cmd.Parameters.AddWithValue("@a",a);
                cmd.Parameters.AddWithValue("@c",c);
                cmd.ExecuteNonQuery();

              /*  SqlCommand cmd2 = new SqlCommand("insert into [dbo].[games_owned] values (@d,@u )", con);
                cmd2.Parameters.AddWithValue("@d",u );
                cmd2.Parameters.AddWithValue("@u",g );
                cmd2.ExecuteNonQuery();*/

                con.Close();
                Response.Redirect("~/login/user.aspx");


            }
            else
            {
                Label2.Text = "Invalid username or password.";
                Label2.Visible = true;
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login/user.aspx");
        }
    }
}