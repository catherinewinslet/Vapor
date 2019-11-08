using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dbms_project.welcome
{
    public partial class welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login/WebForm2.aspx"); 
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/register/WebForm1.aspx");
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/publisher_login/plogin.aspx");
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/publisher_register/pregister.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            //useless function
            Response.Redirect("~/welcome/adminlogin.aspx");
        }
    }
}