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
    public partial class c : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserBL userBL = new UserBL();
                int year = Utils.GetIntValue(Request["Year"]);
                string mode = Utils.GetStringValue(Request["Mode"]);



                UserEntity user = Session[Constants.USERSESSIONVAR] as UserEntity;
                CEntity cc = userBL.GetFormCData(year, user.UserId);

                if (cc != null)
                {
                 

                    shares_script_description.Value = cc.shares_script_description.ToString();
                    shares_facevalue.Value = cc.shares_facevalue.ToString();
                    shares_purchase_consideration.Value = cc.shares_purchase_consideration.ToString();
                    shares_howacquired.Value = cc.shares_howacquired.ToString();
                    shares_relationship.Value = cc.shares_relationship.ToString();

                    debenture_script_description.Value = cc.debenture_script_description.ToString();
                    debenture_facevalue.Value = cc.debenture_facevalue.ToString();
                    debenture_purchase_consideration.Value = cc.debenture_purchase_consideration.ToString();
                    debenture_howacquired.Value = cc.debenture_howacquired.ToString();
                    debenture_relationship.Value = cc.debenture_relationship.ToString();

                    units_script_description.Value = cc.units_script_description.ToString();
                    units_facevalue.Value = cc.units_facevalue.ToString();
                    units_purchase_consideration.Value = cc.units_purchase_consideration.ToString();
                    units_howacquired.Value = cc.units_howacquired.ToString();
                    units_relationship.Value = cc.units_relationship.ToString();

                    nscs_script_description.Value = cc.nscs_script_description.ToString();
                    nscs_facevalue.Value = cc.nscs_facevalue.ToString();
                    nscs_purchase_consideration.Value = cc.nscs_purchase_consideration.ToString();
                    nscs_howacquired.Value = cc.nscs_howacquired.ToString();
                    nscs_relationship.Value = cc.nscs_relationship.ToString();

                    nss_script_description.Value = cc.nss_script_description.ToString();
                    nss_facevalue.Value = cc.nss_facevalue.ToString();
                    nss_purchase_consideration.Value = cc.nss_purchase_consideration.ToString();
                    nss_howacquired.Value = cc.nss_howacquired.ToString();
                    nss_relationship.Value = cc.nss_relationship.ToString();

                    allbank_script_description.Value = cc.allbank_script_description.ToString();
                    allbank_facevalue.Value = cc.allbank_facevalue.ToString();
                    allbank_purchase_consideration.Value = cc.allbank_purchase_consideration.ToString();
                    allbank_howacquired.Value = cc.allbank_howacquired.ToString();
                    allbank_relationship.Value = cc.allbank_relationship.ToString();


                    othersecurity_script_description.Value = cc.othersecurity_script_description.ToString();
                    othersecurity_facevalue.Value = cc.othersecurity_facevalue.ToString();
                    othersecurity_purchase_consideration.Value = cc.othersecurity_purchase_consideration.ToString();
                    othersecurity_howacquired.Value = cc.othersecurity_howacquired.ToString();
                    othersecurity_relationship.Value = cc.othersecurity_relationship.ToString();

                    allother_script_description.Value = cc.allother_script_description.ToString();
                    allother_facevalue.Value = cc.allother_facevalue.ToString();
                    allother_purchase_consideration.Value = cc.allother_purchase_consideration.ToString();
                    allother_howacquired.Value = cc.allother_howacquired.ToString();
                    allother_relationship.Value = cc.allother_relationship.ToString();

        

                 
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



        protected void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected void btnNext_Click(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            CEntity cc = new CEntity();


            cc.shares_script_description = Utils.GetStringValue(shares_script_description.Value);
            cc.shares_facevalue = Utils.GetDoubleValue(shares_facevalue.Value);
            cc.shares_purchase_consideration = Utils.GetDoubleValue(shares_purchase_consideration.Value);
            cc.shares_howacquired = Utils.GetStringValue(shares_howacquired.Value);
            cc.shares_relationship = Utils.GetStringValue(shares_relationship.Value);
            cc.debenture_script_description = Utils.GetStringValue(debenture_script_description.Value);
            cc.debenture_facevalue = Utils.GetDoubleValue(debenture_facevalue.Value);
            cc.debenture_purchase_consideration = Utils.GetDoubleValue(debenture_purchase_consideration.Value);
            cc.debenture_howacquired = Utils.GetStringValue(debenture_howacquired.Value);
            cc.debenture_relationship = Utils.GetStringValue(debenture_relationship.Value);
            cc.units_script_description = Utils.GetStringValue(units_script_description.Value);
            cc.units_facevalue = Utils.GetDoubleValue(units_facevalue.Value);
            cc.units_purchase_consideration = Utils.GetDoubleValue(units_purchase_consideration.Value);
            cc.units_howacquired = Utils.GetStringValue(units_howacquired.Value);
            cc.units_relationship = Utils.GetStringValue(units_relationship.Value);
            cc.nscs_script_description = Utils.GetStringValue(nscs_script_description.Value);
            cc.nscs_facevalue = Utils.GetDoubleValue(nscs_facevalue.Value);
            cc.nscs_purchase_consideration = Utils.GetDoubleValue(nscs_purchase_consideration.Value);
            cc.nscs_howacquired = Utils.GetStringValue(nscs_howacquired.Value);
            cc.nscs_relationship = Utils.GetStringValue(nscs_relationship.Value);
            cc.nss_script_description = Utils.GetStringValue(nss_script_description.Value);
            cc.nss_facevalue = Utils.GetDoubleValue(nss_facevalue.Value);
            cc.nss_purchase_consideration = Utils.GetDoubleValue(nss_purchase_consideration.Value);
            cc.nss_howacquired = Utils.GetStringValue(nss_howacquired.Value);
            cc.nss_relationship = Utils.GetStringValue(nss_relationship.Value);
            cc.allbank_script_description = Utils.GetStringValue(allbank_script_description.Value);
            cc.allbank_facevalue = Utils.GetDoubleValue(allbank_facevalue.Value);
            cc.allbank_purchase_consideration = Utils.GetDoubleValue(allbank_purchase_consideration.Value);
            cc.allbank_howacquired = Utils.GetStringValue(allbank_howacquired.Value);
            cc.allbank_relationship = Utils.GetStringValue(allbank_relationship.Value);
            cc.othersecurity_script_description = Utils.GetStringValue(othersecurity_script_description.Value);
            cc.othersecurity_facevalue = Utils.GetDoubleValue(othersecurity_facevalue.Value);
            cc.othersecurity_purchase_consideration = Utils.GetDoubleValue(othersecurity_purchase_consideration.Value);
            cc.othersecurity_howacquired = Utils.GetStringValue(othersecurity_howacquired.Value);
            cc.othersecurity_relationship = Utils.GetStringValue(othersecurity_relationship.Value);
            cc.allother_script_description = Utils.GetStringValue(allother_script_description.Value);
            cc.allother_facevalue = Utils.GetDoubleValue(allother_facevalue.Value);
            cc.allother_purchase_consideration = Utils.GetDoubleValue(allother_purchase_consideration.Value);
            cc.allother_howacquired = Utils.GetStringValue(allother_howacquired.Value);
            cc.allother_relationship = Utils.GetStringValue(allother_relationship.Value);


            UserBL userBL = new UserBL();
            int year = Utils.GetIntValue(Request["Year"]);

            UserEntity user = Session[Constants.USERSESSIONVAR] as UserEntity;
            userBL.SaveFormC(cc, year, user.UserId);
        }


    }
}