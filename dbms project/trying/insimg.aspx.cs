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

namespace dbms_project.trying
{
    public partial class insimg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("addimg", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter paramName = new SqlParameter()
                    {
                        ParameterName = "@name",
                        Value = TextBox1.Text
                    };
                    cmd.Parameters.Add(paramName);
                   
                    SqlParameter paramImageData = new SqlParameter()
                    {
                        ParameterName = "@img",
                        Value = bytes
                    };
                    cmd.Parameters.Add(paramImageData);
                    
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
