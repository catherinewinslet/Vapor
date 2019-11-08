using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dbms_project.publisher_login
{
    public partial class paddgame : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\Archit\source\repos\dbms project\dbms project\App_Data\mydata.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

             

            SqlCommand cmd = new SqlCommand("insert into [dbo].[games] values (@name,@st,@size,@price )", con);

            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@size", TextBox2.Text);
            cmd.Parameters.AddWithValue("@price", TextBox3.Text);
            cmd.Parameters.AddWithValue("@st", Session["add"].ToString());
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();

            Label1.Visible = true;
            Label1.Text = "Game Registered Successfully";

            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/publisher_login/pdashbord.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/Files/");

            //Check whether Directory (Folder) exists.
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists Create it.
                Directory.CreateDirectory(folderPath);
            }

            //Save the File to the Directory (Folder).
            FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));

            //Display the Picture in Image control.
            Image1.ImageUrl = "~/Files/" + Path.GetFileName(FileUpload1.FileName);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
     
            HttpPostedFile postedFile = FileUpload1.PostedFile;
            string fileName = Path.GetFileName(postedFile.FileName);
            string fileExtension = Path.GetExtension(fileName);
            int fileSize = postedFile.ContentLength;
            if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".bmp" || fileExtension.ToLower() == ".gif" || fileExtension.ToLower() == ".png")
            {
                Stream stream = postedFile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);
                byte[] bytes = binaryReader.ReadBytes((int)stream.Length);
                string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("gadd", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter paramName = new SqlParameter()
                    {
                        ParameterName = "@game_name",
                        Value = TextBox1.Text
                    };
                    cmd.Parameters.Add(paramName);
                    SqlParameter paramSize = new SqlParameter()
                    {
                        ParameterName = "@size",
                        Value = TextBox2.Text
                    };
                    cmd.Parameters.Add(paramSize);
                    SqlParameter paramImageData = new SqlParameter()
                    {
                        ParameterName = "@img",
                        Value = bytes
                    };
                    cmd.Parameters.Add(paramImageData);
                    SqlParameter paramNewInt = new SqlParameter()
                    {
                        ParameterName = "@price",
                        Value = TextBox3.Text
                        
                    };
                    cmd.Parameters.Add(paramNewInt);
                    SqlParameter pubt = new SqlParameter()
                    {
                        ParameterName = "@publisher",
                        Value = Session["add"].ToString()

                    };
                    cmd.Parameters.Add(pubt);

                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Label1.Visible = true;
                    Label1.Text = "upload successfully";

                }


            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "only images allowed";
            }
        }
    }
    }
