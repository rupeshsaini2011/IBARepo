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
    public partial class a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                UserBL userBL = new UserBL();
                int year = Utils.GetIntValue(Request["Year"]);
                string mode = Utils.GetStringValue(Request["Mode"]);

               

                UserEntity user = Session[Constants.USERSESSIONVAR] as UserEntity;
                AEntity aa = userBL.GetFormAData(year, user.UserId);

                if (aa != null)
                {
                    inputName.Value = aa.Name;
                    inputDesignation.Value = aa.Designation;
                    inputInstitution.Value = aa.Institute;
                    txtVillage.Value = aa.Village;
                    txtTehsil.Value = aa.Tehsil;
                    txtDistrict.Value = aa.District;
                    txtCity.Value = aa.City;
                    txtState.Value = aa.State;
                    txtPincode.Value = aa.PinCode;

                    txtDescription.InnerText = aa.OtherDetails;

                    txtPresentValue.Value = aa.CurrentValue.ToString();

                    chkOwnNameYes.Checked = aa.OwnName;
                    txtOwnerName.Value = aa.OwnerName;
                    txtOwnerRelation.Value = aa.OwnerRelation;
                    ddlHowAcquired.Value = aa.HowAcquired.ToString();
                    txtPersonFromAcquired.Value = aa.AcquiredFrom;
                    txtDateAcquired.Value = aa.AcquiredDate.ToString();

                    txtFundingDetails.Value = aa.FundingSource;
                    txtAnnualIncome.Value = aa.AnnualIncome.ToString();
                    txtOtherInfo.Value = aa.OtherDetails;


                }


                if (mode == Constants.VIEWMODE)
                {
                    foreach (Control c in Page.Controls)
                    {
                        foreach (Control ctrl in c.Controls)
                        {
                            if (ctrl is TextBox)
                                (ctrl as TextBox).Enabled = false;
                        }

                    }


                }



            }




        }

        protected void btnNext_Click(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            AEntity aa = new AEntity();
            aa.Name = inputName.Value;
            aa.Designation = inputDesignation.Value;
            aa.Institute = inputInstitution.Value;
            aa.Village = txtVillage.Value;
            aa.Tehsil = txtTehsil.Value;
            aa.District = txtDistrict.Value;
            aa.City = txtCity.Value;
            aa.State = txtState.Value;
            aa.PinCode = txtPincode.Value;

            aa.OtherDetails = txtDescription.InnerText;

            aa.CurrentValue =  Utils.GetDoubleValue( txtPresentValue.Value);

            aa.OwnName = chkOwnNameYes.Checked;
            aa.OwnerName = txtOwnerName.Value;
            aa.OwnerRelation = txtOwnerRelation.Value;
            aa.HowAcquired = (Constants.HowAcquired)Enum.Parse(typeof(Constants.HowAcquired), ddlHowAcquired.Value);
            aa.AcquiredFrom = txtPersonFromAcquired.Value;
            aa.AcquiredDate = Utils.GetDateTimeValue(txtDateAcquired.Value).Value;

            aa.FundingSource = txtFundingDetails.Value;
            aa.AnnualIncome = Utils.GetDoubleValue( txtAnnualIncome.Value);
            aa.OtherDetails = txtOtherInfo.Value;

            UserBL userBL = new UserBL();
            int year = Utils.GetIntValue(Request["Year"]);

            UserEntity user = Session[Constants.USERSESSIONVAR] as UserEntity;
            userBL.SaveFormA(aa, year, user.UserId);


        }

        protected void btnBack_Click(object sender, EventArgs e)
        {

        }



    }
}