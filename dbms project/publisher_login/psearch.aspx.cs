using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dbms_project.publisher_login
{
    public partial class psearch : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\Archit\source\repos\dbms project\dbms project\App_Data\mydata.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string st = TextBox1.Text;
            SqlCommand cmd = new SqlCommand("select count(*) from games where game_name=@u and publisher=@p;", con);
            cmd.Parameters.AddWithValue("@u", TextBox1.Text);
            cmd.Parameters.AddWithValue("@p", Session["add"].ToString());
            con.Open();
            string i = cmd.ExecuteScalar().ToString();
            int rd = int.Parse(i);
            if (rd != 0)
            {
                Session["search"] = TextBox1.Text;
                Response.Redirect("~/publisher_login/pedit.aspx");
            }
            else
            {
                Label1.Text = "This game is not present in your Library.";            }
        }
    }
}