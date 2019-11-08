using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace dbms_project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\Archit\source\repos\dbms project\dbms project\App_Data\mydata.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try {
                if (TextBox3.Text == "" || TextBox2.Text == "" || TextBox4.Text == "")
                {
                    Label6.Text = "Fields cannot be empty";
                }

                else
                {
                    SqlCommand cmd = new SqlCommand("insert into [dbo].[user] values (@user,@password, @age )", con);

                    cmd.Parameters.AddWithValue("@user", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@password", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@age", TextBox4.Text);
                    con.Open();

                    cmd.ExecuteNonQuery();
                    con.Close();

                    

                    Response.Redirect("~/login/WebForm2.aspx");
                }
            }
            catch
            {
                Label6.Text = "Fields cannot be empty";
            }


        }

    }
}

