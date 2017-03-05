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
    public partial class d : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserBL userBL = new UserBL();
                int year = Utils.GetIntValue(Request["Year"]);
                string mode = Utils.GetStringValue(Request["Mode"]);

                UserEntity user = Session[Constants.USERSESSIONVAR] as UserEntity;
                DEntity dd = userBL.GetFormDData(year, user.UserId);

                if (dd != null)
                {
                    LoanFriends.Value = dd.LoanFriends.ToString();
                    LoanSecurity.Value = dd.LoanSecurity.ToString();
                    OtherLiability.Value = dd.OtherLiability.ToString();

                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            DEntity dd = new DEntity();
            dd.LoanFriends = Utils.GetDoubleValue(LoanFriends.Value);
            dd.LoanSecurity = Utils.GetDoubleValue(LoanSecurity.Value);
            dd.OtherLiability = Utils.GetStringValue(OtherLiability.Value);

            UserBL userBL = new UserBL();
            int year = Utils.GetIntValue(Request["Year"]);

            UserEntity user = Session[Constants.USERSESSIONVAR] as UserEntity;
            userBL.SaveFormD(dd, year, user.UserId);

        }


        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Users.aspx");

        }



    }
}