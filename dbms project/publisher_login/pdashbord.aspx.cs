using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dbms_project.publisher_login
{
    public partial class pdashbord : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\Archit\source\repos\dbms project\dbms project\App_Data\mydata.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["plogin"].ToString();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM games WHERE(publisher=@uid)";
            cmd.Parameters.AddWithValue("@uid", Label1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
           
            SqlDataReader rdr = cmd.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();

            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string st = Label1.Text;
            Session["add"] = st;
        
        Response.Redirect("~/publisher_login/paddgame.aspx");
             }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["add"] = Label1.Text;
            Response.Redirect("~/publisher_login/psearch.aspx");
          
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["add"] = Label1.Text;
            Response.Redirect("~/publisher_login/pdelete.aspx");
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}