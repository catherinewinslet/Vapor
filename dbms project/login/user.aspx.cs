using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dbms_project.login
{
    public partial class user : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\Archit\source\repos\dbms project\dbms project\App_Data\mydata.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            string q=Label2.Text = Session["login"].ToString();
            string result = "SELECT user_id FROM[user] WHERE[user] = '" + Session["login"].ToString() + "'";
            SqlCommand showresult1 = new SqlCommand(result, con);
              con.Open();
            string str = showresult1.ExecuteScalar().ToString();
           
          
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText= "SELECT  * FROM games WHERE game_id  IN (SELECT game_id FROM games_owned WHERE ([user_id]=@uid))";
            cmd.Parameters.AddWithValue("@uid", str);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            SqlDataReader rdr = cmd.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();

            con.Close();

        }
        protected void Button1_click(object sender, EventArgs e)
        {
            Response.Redirect("~/search/search.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}