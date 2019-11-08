using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dbms_project.search
{
    public partial class result : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\Archit\source\repos\dbms project\dbms project\App_Data\mydata.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["value"].ToString();
            Label6.Text = Label1.Text;
            string q= Session["value"].ToString();
            string result = "SELECT publisher FROM [dbo].[games] WHERE game_name = '" + q + "'";
            SqlCommand showresult = new SqlCommand(result, con);
            con.Open();
            Label2.Text = showresult.ExecuteScalar().ToString();
           
            string result1 = "SELECT size FROM [dbo].[games] WHERE game_name = '" + q + "'";
            SqlCommand showresult1 = new SqlCommand(result1, con);
            
            Label3.Text = showresult1.ExecuteScalar().ToString();
            
            string result2 = "SELECT price FROM [dbo].[games] WHERE game_name = '" + q + "'";
            SqlCommand showresult2 = new SqlCommand(result2, con);
           
            Label4.Text = showresult2.ExecuteScalar().ToString();

            

            Label5.Text= Session["login"].ToString();
            SqlCommand cmd = new SqlCommand("select * from games WHERE game_name = '" + q + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
            SqlDataReader dr2 = cmd.ExecuteReader();
            GridView2.DataSource = dr2; 
            GridView2.DataBind();
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["game"] = Label1.Text;
            Session["result"]= Label5.Text;
            Response.Redirect("trans.aspx");
        }
    }
}