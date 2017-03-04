using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using IBAEntities;
using IBA_BL;

namespace IBAWeb2
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int startYear = Utils.GetIntValue( ConfigurationManager.AppSettings[Constants.StartYear].ToString());

            UserEntity user = Session[Constants.USERSESSIONVAR] as UserEntity;
            UserBL bl = new UserBL();
            if (user != null)
            {

                List<SubmissionEntity> allSubmissions = bl.GetSubmisisons(user.UserId);
                List<YearSubmissions> allYearSubmissions = new List<YearSubmissions>();

                for (int i = startYear; i <= DateTime.Now.Year; i++)
                {
                    YearSubmissions ys = new YearSubmissions();
                    ys.Year = i;
                    SubmissionEntity sub = null;
                    if (allSubmissions != null)
                    {
                        sub = allSubmissions.FirstOrDefault(s => s.SubmissionYear == i);
                    }
                    ys.submission = sub;
                    ys.submitted = (sub != null);


                    allYearSubmissions.Add(ys);
                }

                grdYear.DataSource = allYearSubmissions;
                grdYear.DataBind();

            }





        }


        protected void grdYear_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                YearSubmissions ys = e.Row.DataItem as YearSubmissions;



            }


    }
}