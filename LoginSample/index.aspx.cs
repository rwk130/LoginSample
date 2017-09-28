using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwkraemer.Code;

namespace MovieList
{
    public partial class index: System.Web.UI.Page
    {
        protected void Page_Load( object sender, EventArgs e )
        {

        }

        protected void btnSubmit_Click( object sender, EventArgs e )
        {
            VerifyPage();
            if(Page.IsValid)
            {
                AppConfig.User = new Contact() { Address = txtAddress.Text, Email = txtEmail.Text, FirstName = txtFirstName.Text, LastName = txtLastName.Text,
                    MiddleName = txtMiddleName.Text };
                pnlCreate.Visible = false;
                pnlPassword.Visible = true;
                lblPassword.Text = AppConfig.User.CreatePassword();
            }
        }

        private void VerifyPage()
        {
            cvName.IsValid = cvName.IsValid & PageUtility.Alpha_Capitalized_Required( txtFirstName );
            cvName.IsValid = cvName.IsValid & PageUtility.Alpha_Capitalized_Nonrequired( txtMiddleName );
            cvName.IsValid = cvName.IsValid & PageUtility.Alpha_Capitalized_Required( txtLastName );
            cvAddress.IsValid = PageUtility.AlphaNumeric_Capitalized_Required( txtAddress );
            cvEmail.IsValid = PageUtility.Email_Required( txtEmail );
        }
    }
}