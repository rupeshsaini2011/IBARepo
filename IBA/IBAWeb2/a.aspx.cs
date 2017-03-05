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
            userBL.SaveFormA(aa);


        }

        protected void btnBack_Click(object sender, EventArgs e)
        {

        }



    }
}