using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dbms_project.welcome
{
    public partial class adminlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string si = "vapouradmin";
            string sp = "letmein";
            if(TextBox1.Text==si && TextBox2.Text==sp)
            {
                Response.Redirect("~/welcome/administraor.aspx");
            }
            else
            {
                Label1.Text = "wrong credendials";
            }
        }
    }
}