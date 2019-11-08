using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dbms_project.publisher_register
{
    public partial class pregister : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\Archit\source\repos\dbms project\dbms project\App_Data\mydata.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox3.Text == "" || TextBox2.Text == "" || TextBox4.Text == "" || TextBox1.Text == "")
                {
                    Label1.Text = "fields cant be empty";
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into [dbo].[publisher] values (@pub_name,@address, @phone_no,@password )", con);

                    cmd.Parameters.AddWithValue("@pub_name", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@address", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@phone_no", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@password", TextBox4.Text);
                    con.Open();

                    cmd.ExecuteNonQuery();
                    con.Close();

                    Response.Redirect("~/publisher_login/plogin.aspx");
                }
            }
            catch
            {
                Label1.Text = "invalid";
            }
        }

    }
}
