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
    public partial class b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserBL userBL = new UserBL();
                int year = Utils.GetIntValue(Request["Year"]);
                string mode = Utils.GetStringValue(Request["Mode"]);



                UserEntity user = Session[Constants.USERSESSIONVAR] as UserEntity;
                BEntity bb = userBL.GetFormBData(year, user.UserId);

                if (bb != null)
                {
                    LastYearSharesNo.Value = bb.LastYearSharesNo.ToString();
                    LastYearSharesValue.Value = bb.LastYearSharesValue.ToString();
                    LastyearSharesCostofacquisition.Value = bb.LastyearSharesCostofacquisition.ToString();
                    CurrentYearSharesNo.Value = bb.CurrentYearSharesNo.ToString();
                    CurrentYearSharesValue.Value = bb.CurrentYearSharesValue.ToString();
                    CurrentyearSharesCostofacquisition.Value = bb.CurrentyearSharesCostofacquisition.ToString();
                    ThisyearSharesCostofacquisition.Value = bb.ThisyearSharesCostofacquisition.ToString();
                    SharesFundingSource.Value = bb.SharesFundingSource.ToString();

                    LastYearDebenturesNo.Value = bb.LastYearDebenturesNo.ToString();
                    LastYearDebenturesValue.Value = bb.LastYearDebenturesValue.ToString();
                    LastyearDebenturesCostofacquisition.Value = bb.LastyearDebenturesCostofacquisition.ToString();
                    CurrentYearDebenturesNo.Value = bb.CurrentYearDebenturesNo.ToString();
                    CurrentYearDebenturesValue.Value = bb.CurrentYearDebenturesValue.ToString();
                    CurrentyearDebenturesCostofacquisition.Value = bb.CurrentyearDebenturesCostofacquisition.ToString();
                    ThisyearDebenturesCostofacquisition.Value = bb.ThisyearDebenturesCostofacquisition.ToString();
                    DebenturesFundingSource.Value = bb.DebenturesFundingSource.ToString();

                    LastYearUnitsNo.Value = bb.LastYearUnitsNo.ToString();
                    LastYearUnitsValue.Value = bb.LastYearUnitsValue.ToString();
                    LastyearUnitsCostofacquisition.Value = bb.LastyearUnitsCostofacquisition.ToString();
                    CurrentYearUnitsNo.Value = bb.CurrentYearUnitsNo.ToString();
                    CurrentYearUnitsValue.Value = bb.CurrentYearUnitsValue.ToString();
                    CurrentyearUnitsCostofacquisition.Value = bb.CurrentyearUnitsCostofacquisition.ToString();
                    ThisyearUnitsCostofacquisition.Value = bb.ThisyearUnitsCostofacquisition.ToString();
                    UnitsFundingSource.Value = bb.UnitsFundingSource.ToString();

                    LastYearNSCNo.Value = bb.LastYearNSCNo.ToString();
                    LastYearNSCValue.Value = bb.LastYearNSCValue.ToString();
                    LastyearNSCCostofacquisition.Value = bb.LastyearNSCCostofacquisition.ToString();
                    CurrentYearNSCNo.Value = bb.CurrentYearNSCNo.ToString();
                    CurrentYearNSCValue.Value = bb.CurrentYearNSCValue.ToString();
                    CurrentyearNSCCostofacquisition.Value = bb.CurrentyearNSCCostofacquisition.ToString();
                    ThisyearNSCCostofacquisition.Value = bb.ThisyearNSCCostofacquisition.ToString();
                    NSCFundingSource.Value = bb.NSCFundingSource.ToString();

                    LastYearNSSNo.Value = bb.LastYearNSSNo.ToString();
                    LastYearNSSValue.Value = bb.LastYearNSSValue.ToString();
                    LastyearNSSCostofacquisition.Value = bb.LastyearNSSCostofacquisition.ToString();
                    CurrentYearNSSNo.Value = bb.CurrentYearNSSNo.ToString();
                    CurrentYearNSSValue.Value = bb.CurrentYearNSSValue.ToString();
                    CurrentyearNSSCostofacquisition.Value = bb.CurrentyearNSSCostofacquisition.ToString();
                    ThisyearNSSCostofacquisition.Value = bb.ThisyearNSSCostofacquisition.ToString();
                    NSSFundingSource.Value = bb.NSSFundingSource.ToString();

                    LastYearBondsNo.Value = bb.LastYearBondsNo.ToString();
                    LastYearBondsValue.Value = bb.LastYearBondsValue.ToString();
                    LastyearBondsCostofacquisition.Value = bb.LastyearBondsCostofacquisition.ToString();
                    CurrentYearBondsNo.Value = bb.CurrentYearBondsNo.ToString();
                    CurrentYearBondsValue.Value = bb.CurrentYearBondsValue.ToString();
                    CurrentyearBondsCostofacquisition.Value = bb.CurrentyearBondsCostofacquisition.ToString();
                    ThisyearBondsCostofacquisition.Value = bb.ThisyearBondsCostofacquisition.ToString();
                    BondsFundingSource.Value = bb.BondsFundingSource.ToString();

                    LastYearDepositsNo.Value = bb.LastYearDepositsNo.ToString();
                    LastYearDepositsValue.Value = bb.LastYearDepositsValue.ToString();
                    LastYearDepositsCostofacquisition.Value = bb.LastyearDepositsCostofacquisition.ToString();
                    CurrentYearDepositsNo.Value = bb.CurrentYearDepositsNo.ToString();
                    CurrentYearDepositsValue.Value = bb.CurrentYearDepositsValue.ToString();
                    CurrentyearDepositsCostofacquisition.Value = bb.CurrentyearDepositsCostofacquisition.ToString();
                    ThisyearDepositsCostofacquisition.Value = bb.ThisyearDepositsCostofacquisition.ToString();
                    DepositsFundingSource.Value = bb.DepositsFundingSource.ToString();


                    LastYearOthersNo.Value = bb.LastYearOthersNo.ToString();
                    LastYearOthersValue.Value = bb.LastYearOthersValue.ToString();
                    LastyearOthersCostofacquisition.Value = bb.LastyearOthersCostofacquisition.ToString();
                    CurrentYearOthersNo.Value = bb.CurrentYearOthersNo.ToString();
                    CurrentYearOthersValue.Value = bb.CurrentYearOthersValue.ToString();
                    CurrentyearOthersCostofacquisition.Value = bb.CurrentyearOthersCostofacquisition.ToString();
                    ThisyearOthersCostofacquisition.Value = bb.ThisyearOthersCostofacquisition.ToString();
                    OthersFundingSource.Value = bb.OthersFundingSource.ToString();
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
            Response.Redirect("c.aspx?Year=" + Request["Year"]);
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Users.aspx");
        }


        protected void btnSave_Click(object sender, EventArgs e)
        {

            BEntity bb = new BEntity();


            bb.LastYearSharesNo = Utils.GetIntValue( LastYearSharesNo.Value);
        bb.LastYearSharesValue = Utils.GetDoubleValue(LastYearSharesValue.Value);
        bb.LastyearSharesCostofacquisition = Utils.GetDoubleValue(LastyearSharesCostofacquisition.Value);
        bb.CurrentYearSharesNo = Utils.GetIntValue(CurrentYearSharesNo.Value);
        bb.CurrentYearSharesValue = Utils.GetDoubleValue(CurrentYearSharesValue.Value);
        bb.CurrentyearSharesCostofacquisition = Utils.GetDoubleValue(CurrentyearSharesCostofacquisition.Value);
        bb.ThisyearSharesCostofacquisition = Utils.GetDoubleValue(ThisyearSharesCostofacquisition.Value);
        bb.SharesFundingSource = Utils.GetStringValue(SharesFundingSource.Value);

            bb.LastYearDebenturesNo = Utils.GetIntValue(LastYearDebenturesNo.Value);
            bb.LastYearDebenturesValue = Utils.GetDoubleValue(LastYearDebenturesValue.Value);
            bb.LastyearDebenturesCostofacquisition = Utils.GetDoubleValue(LastyearDebenturesCostofacquisition.Value);
            bb.CurrentYearDebenturesNo = Utils.GetIntValue(CurrentYearDebenturesNo.Value);
            bb.CurrentYearDebenturesValue = Utils.GetDoubleValue(CurrentYearDebenturesValue.Value);
            bb.CurrentyearDebenturesCostofacquisition = Utils.GetDoubleValue(CurrentyearDebenturesCostofacquisition.Value);
            bb.ThisyearDebenturesCostofacquisition = Utils.GetDoubleValue(ThisyearDebenturesCostofacquisition.Value);
            bb.DebenturesFundingSource = Utils.GetStringValue(DebenturesFundingSource.Value);

            bb.LastYearUnitsNo = Utils.GetIntValue(LastYearUnitsNo.Value);
            bb.LastYearUnitsValue = Utils.GetDoubleValue(LastYearUnitsValue.Value);
            bb.LastyearUnitsCostofacquisition = Utils.GetDoubleValue(LastyearUnitsCostofacquisition.Value);
            bb.CurrentYearUnitsNo = Utils.GetIntValue(CurrentYearUnitsNo.Value);
            bb.CurrentYearUnitsValue = Utils.GetDoubleValue(CurrentYearUnitsValue.Value);
            bb.CurrentyearUnitsCostofacquisition = Utils.GetDoubleValue(CurrentyearUnitsCostofacquisition.Value);
            bb.ThisyearUnitsCostofacquisition = Utils.GetDoubleValue(ThisyearUnitsCostofacquisition.Value);
            bb.UnitsFundingSource = Utils.GetStringValue(UnitsFundingSource.Value);


            bb.LastYearBondsNo = Utils.GetIntValue(LastYearBondsNo.Value);
            bb.LastYearBondsValue = Utils.GetDoubleValue(LastYearBondsValue.Value);
            bb.LastyearBondsCostofacquisition = Utils.GetDoubleValue(LastyearBondsCostofacquisition.Value);
            bb.CurrentYearBondsNo = Utils.GetIntValue(CurrentYearBondsNo.Value);
            bb.CurrentYearBondsValue = Utils.GetDoubleValue(CurrentYearBondsValue.Value);
            bb.CurrentyearBondsCostofacquisition = Utils.GetDoubleValue(CurrentyearBondsCostofacquisition.Value);
            bb.ThisyearBondsCostofacquisition = Utils.GetDoubleValue(ThisyearBondsCostofacquisition.Value);
            bb.BondsFundingSource = Utils.GetStringValue(BondsFundingSource.Value);



            bb.LastYearNSCNo = Utils.GetIntValue(LastYearNSCNo.Value);
            bb.LastYearNSCValue = Utils.GetDoubleValue(LastYearNSCValue.Value);
            bb.LastyearNSCCostofacquisition = Utils.GetDoubleValue(LastyearNSCCostofacquisition.Value);
            bb.CurrentYearNSCNo = Utils.GetIntValue(CurrentYearNSCNo.Value);
            bb.CurrentYearNSCValue = Utils.GetDoubleValue(CurrentYearNSCValue.Value);
            bb.CurrentyearNSCCostofacquisition = Utils.GetDoubleValue(CurrentyearNSCCostofacquisition.Value);
            bb.ThisyearNSCCostofacquisition = Utils.GetDoubleValue(ThisyearNSCCostofacquisition.Value);
            bb.NSCFundingSource = Utils.GetStringValue(NSCFundingSource.Value);


            bb.LastYearNSSNo = Utils.GetIntValue(LastYearNSSNo.Value);
            bb.LastYearNSSValue = Utils.GetDoubleValue(LastYearNSSValue.Value);
            bb.LastyearNSSCostofacquisition = Utils.GetDoubleValue(LastyearNSSCostofacquisition.Value);
            bb.CurrentYearNSSNo = Utils.GetIntValue(CurrentYearNSSNo.Value);
            bb.CurrentYearNSSValue = Utils.GetDoubleValue(CurrentYearNSSValue.Value);
            bb.CurrentyearNSSCostofacquisition = Utils.GetDoubleValue(CurrentyearNSSCostofacquisition.Value);
            bb.ThisyearNSSCostofacquisition = Utils.GetDoubleValue(ThisyearNSSCostofacquisition.Value);
            bb.NSSFundingSource = Utils.GetStringValue(NSSFundingSource.Value);

            
            bb.LastYearDepositsNo = Utils.GetIntValue(LastYearDepositsNo.Value);
            bb.LastYearDepositsValue = Utils.GetDoubleValue(LastYearDepositsValue.Value);
            bb.LastyearDepositsCostofacquisition = Utils.GetDoubleValue(LastYearDepositsCostofacquisition.Value);
            bb.CurrentYearDepositsNo = Utils.GetIntValue(CurrentYearDepositsNo.Value);
            bb.CurrentYearDepositsValue = Utils.GetDoubleValue(CurrentYearDepositsValue.Value);
            bb.CurrentyearDepositsCostofacquisition = Utils.GetDoubleValue(CurrentyearDepositsCostofacquisition.Value);
            bb.ThisyearDepositsCostofacquisition = Utils.GetDoubleValue(ThisyearDepositsCostofacquisition.Value);
            bb.DepositsFundingSource = Utils.GetStringValue(DepositsFundingSource.Value);


            bb.LastYearOthersNo = Utils.GetIntValue(LastYearOthersNo.Value);
            bb.LastYearOthersValue = Utils.GetDoubleValue(LastYearOthersValue.Value);
            bb.LastyearOthersCostofacquisition = Utils.GetDoubleValue(LastyearOthersCostofacquisition.Value);
            bb.CurrentYearOthersNo = Utils.GetIntValue(CurrentYearOthersNo.Value);
            bb.CurrentYearOthersValue = Utils.GetDoubleValue(CurrentYearOthersValue.Value);
            bb.CurrentyearOthersCostofacquisition = Utils.GetDoubleValue(CurrentyearOthersCostofacquisition.Value);
            bb.ThisyearOthersCostofacquisition = Utils.GetDoubleValue(ThisyearOthersCostofacquisition.Value);
            bb.OthersFundingSource = Utils.GetStringValue(OthersFundingSource.Value);





        UserBL userBL = new UserBL();
            int year = Utils.GetIntValue(Request["Year"]);

            UserEntity user = Session[Constants.USERSESSIONVAR] as UserEntity;
            userBL.SaveFormB(bb, year, user.UserId);
        }

    }
}