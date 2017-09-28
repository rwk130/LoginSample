using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwkraemer.Code;

namespace LoginSample
{
    public partial class login: System.Web.UI.Page
    {
        protected void Page_Load( object sender, EventArgs e )
        {

        }

        protected void btnSubmit_Click( object sender, EventArgs e )
        {
            lblReturn.Text = String.Empty;
            string mTemp = PageUtility.EncryptPassword( txtPass.Text );
            if( txtEmail.Text == AppConfig.User.Email && PageUtility.EncryptPassword( txtPass.Text ) == AppConfig.User.Password )
            {
                FormsAuthentication.SetAuthCookie( AppConfig.User.Email, false );
                Response.Redirect( "loggedin/congrats.aspx" );
            }
            else
            {
                lblReturn.Text = "Invalid E-mail and Password combination.";
            }
        }
    }
}