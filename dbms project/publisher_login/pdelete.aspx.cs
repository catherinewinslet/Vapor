using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace dbms_project.publisher_login
{
    public partial class pdelete : System.Web.UI.Page
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
               if( MessageBox.Show("do u really wanna delete the record", "message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd2 = new SqlCommand("delete from games where game_name=@u and publisher=@p;", con);
                    cmd2.Parameters.AddWithValue("@u", TextBox1.Text);
                    cmd2.Parameters.AddWithValue("@p", Session["add"].ToString());
                    
                    cmd2.ExecuteNonQuery();
                    Label1.Text = "Game Deleted";

                }
            }
            else
            {
                Label1.Text = "Game Not Found";
            }
        }
    }
}