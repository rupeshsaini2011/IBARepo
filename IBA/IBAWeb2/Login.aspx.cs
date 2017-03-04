using IBA_BL;
using IBAEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IBAWeb2
{
    public partial class Login : System.Web.UI.Page
    {
        public object UserEntity { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Value;
            string password = txtPassword.Value;

            UserBL userBL = new UserBL();

            UserEntity user = userBL.isAuthenticate(username, password);

            if(user!=null)
            {
                Session[Constants.USERSESSIONVAR] = user;
                Response.Redirect("User.aspx");
            }
 
            


        }


    }
}