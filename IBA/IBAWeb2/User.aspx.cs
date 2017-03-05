using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using IBAEntities;
using IBA_BL;
using System.Web.UI.HtmlControls;

namespace IBAWeb2
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int startYear = Utils.GetIntValue(ConfigurationManager.AppSettings[Constants.StartYear].ToString());

            UserEntity user = Session[Constants.USERSESSIONVAR] as UserEntity;
            UserBL bl = new UserBL();
            if (user != null)
            {

                List<SubmissionEntity> allSubmissions = bl.GetSubmissions(user.UserId);
                Session[Constants.SUBMITSESSIONVAR] = allSubmissions;
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

                    ys.submitted = (sub != null && sub.SubmittedForms.Count==Constants.AllForms.Count);


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

                HtmlGenericControl sRemove = (HtmlGenericControl)e.Row.FindControl("spanRemove");
                HtmlGenericControl sOK = (HtmlGenericControl)e.Row.FindControl("spanOk");
                LinkButton btnEdit = (LinkButton)e.Row.FindControl("btnEditYear");
                if (ys.submitted)
                {
                    sOK.Visible = true;
                    sRemove.Visible = false;
                    sRemove.Attributes.Add("style", "display:none");
                    btnEdit.Attributes.Add("style", "display:none");
                }
                else
                {
                    sOK.Visible = false;
                    sRemove.Visible = true;
                    sOK.Attributes.Add("style", "display:none");


                }




            }


        }


        protected void grdYear_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int year = Utils.GetIntValue(e.CommandArgument);

            if (e.CommandName == "EditYear")
            {
                lblYear.Text = year.ToString();
                grdForms.Visible = true;
                grdForms.DataSource = Constants.AllForms;
                grdForms.DataBind();



            }

        }






        protected void grdForm_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string aform = e.Row.DataItem as String;
                if (aform != null)
                {
                    Label lblForm = (Label)e.Row.FindControl("lblForm");
                    lblForm.Text = aform;
                    LinkButton btnEdit = (LinkButton)e.Row.FindControl("btnEdit");
                    btnEdit.CommandArgument = aform;
                    LinkButton btnView = (LinkButton)e.Row.FindControl("btnView");
                    btnView.CommandArgument = aform;

                    List<SubmissionEntity> allSubs = Session[Constants.SUBMITSESSIONVAR] as List<SubmissionEntity>;

                    if (allSubs != null)
                    {
                        SubmissionEntity sub = allSubs.FirstOrDefault(s => s.SubmissionYear == Utils.GetIntValue(lblYear));
                        if (sub != null)
                        {


                        }

                    }




                }

            }
        }


        protected void grdForm_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string aform = e.CommandArgument as String;
            string year = lblYear.Text;
            switch (aform)
            {
                case Constants.FORMA:
                    Response.Redirect("a.aspx?Year="+year);
                    break;
                case Constants.FORMB:
                    Response.Redirect("b.aspx?Year=" + year);
                    break;
                case Constants.FORMC:
                    Response.Redirect("c.aspx?Year=" + year);
                    break;
                case Constants.FORMD:
                    Response.Redirect("d.aspx?Year=" + year);
                    break;


            }

        }





    }
}