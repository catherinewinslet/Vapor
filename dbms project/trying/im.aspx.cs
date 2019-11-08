using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace dbms_project.trying
{
    public partial class im : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Label1.Visible = false;
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpPostedFile postedFile = FileUpload1.PostedFile;
            string fileName = Path.GetFileName(postedFile.FileName);
            string fileExtension = Path.GetExtension(fileName);
            int fileSize = postedFile.ContentLength;
            if(fileExtension.ToLower()==".jpg"|| fileExtension.ToLower() == ".bmp"|| fileExtension.ToLower() == ".gif"|| fileExtension.ToLower() == ".png")
            {
                Stream stream = postedFile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);
               byte[] bytes= binaryReader.ReadBytes((int)stream.Length);
                string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("spUploadImage", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter paramName = new SqlParameter()
                    {
                        ParameterName = "@Name",
                        Value = fileName
                    };
                    cmd.Parameters.Add(paramName);
                    SqlParameter paramSize = new SqlParameter()
                    {
                        ParameterName = "@Size",
                        Value = fileSize
                    };
                    cmd.Parameters.Add(paramSize);
                    SqlParameter paramImageData = new SqlParameter()
                    {
                        ParameterName = "@ImageData",
                        Value = bytes
                    };
                    cmd.Parameters.Add(paramImageData);
                    SqlParameter paramNewInt = new SqlParameter()
                    {
                        ParameterName = "@NewInt",
                        Value = -1,
                        Direction=ParameterDirection.Output
                    };
                    cmd.Parameters.Add(paramNewInt);
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