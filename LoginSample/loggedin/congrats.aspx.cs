using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwkraemer.Code;

namespace LoginSample.loggedin
{
    public partial class congrats: System.Web.UI.Page
    {
        protected void Page_Load( object sender, EventArgs e )
        {
            lblAddress.Text = AppConfig.User.Address;
            lblName.Text = AppConfig.User.DisplayName();
        }
    }
}