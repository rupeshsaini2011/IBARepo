using IBAEntities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace IBA_DAL
{
    public class DBProvider
    {
        string m_connectionString = String.Empty;
        private SqlConnection sqlConn;

        public DBProvider()
        {
            m_connectionString = ConfigurationManager.ConnectionStrings["ibaConnString"].ConnectionString;
        }

        public UserEntity GetAuthenticatedUser(string userName, string password)
        {
            UserEntity user = null;

            DataSet dsUsers = new DataSet();
            SpParamCollection spParams = new SpParamCollection();
            sqlConn = new SqlConnection(m_connectionString);
            spParams.Add(new SpParam("@username", userName));
            spParams.Add(new SpParam("@password", password));



            DBHelper.ExecProcAndFillDataSet("IsAuthenticated", spParams, dsUsers, sqlConn);

            if (dsUsers != null && dsUsers.Tables.Count > 0)
            {
                try
                {
                    DataTable dtUser = dsUsers.Tables[0];

                    if (dtUser != null && dtUser.Rows.Count > 0)
                    {
                        DataRow drUser = dtUser.Rows[0];
                        user = new UserEntity();
                        user.UserId = Utils.GetIntValue(drUser["UserId"]);
                        user.userName = Utils.GetStringValue(drUser["fname"]);
                        user.middleName = Utils.GetStringValue(drUser["mname"]);
                        user.lastName = Utils.GetStringValue(drUser["lname"]);
                        user.passWord = Utils.GetStringValue(drUser["password"]);
                        user.Email = Utils.GetStringValue(drUser["emailid"]);
                        user.BankId = Utils.GetIntValue(drUser["bankid"]);
                        user.SType = (Constants.StaffType)Enum.Parse(typeof(Constants.StaffType), Utils.GetStringValue(drUser["staff_type"]));

                    }
                }
                catch (Exception ex)
                {
                    throw ex;

                }


            }
            return user;
        }

      
        public List<SubmissionEntity> GetSubmissionByUser(int userId)
        {
            List<SubmissionEntity> AllSubmissions = null;

            DataSet dsSubmissions = new DataSet();
            SpParamCollection spParams = new SpParamCollection();
            sqlConn = new SqlConnection(m_connectionString);
            spParams.Add(new SpParam("@userid", userId));

            DBHelper.ExecProcAndFillDataSet("GetSubmissionsByUser", spParams, dsSubmissions, sqlConn);

            if (dsSubmissions != null && dsSubmissions.Tables.Count > 0)
            {
                try
                {
                    DataTable dtSubmission = dsSubmissions.Tables[0];

                    if (dtSubmission != null && dtSubmission.Rows.Count > 0)
                    {
                        for (int j = 0; j < dtSubmission.Rows.Count; j++)
                        {
                            DataRow drSubmission = dtSubmission.Rows[0];
                            SubmissionEntity sub = new SubmissionEntity();
                            sub = new SubmissionEntity();
                            sub.SubmissionId = Utils.GetIntValue(drSubmission["Id"]);
                            sub.SubmissionYear = Utils.GetIntValue(drSubmission["year"]);
                            sub.SubmissionDate = Utils.GetDateTimeValue(drSubmission["create_at"].ToString()).Value;
                            sub.SubmittedForms = new List<string>();



                            if (Utils.GetIntValue(drSubmission["form1id"]) > 0)
                                sub.SubmittedForms.Add(Constants.FORMA);
                            if (Utils.GetIntValue(drSubmission["form2id"]) > 0)
                                sub.SubmittedForms.Add(Constants.FORMB);
                            if (Utils.GetIntValue(drSubmission["form3id"]) > 0)
                                sub.SubmittedForms.Add(Constants.FORMC);
                            if (Utils.GetIntValue(drSubmission["form4id"]) > 0)
                                sub.SubmittedForms.Add(Constants.FORMD);




                            if (AllSubmissions == null)
                                AllSubmissions = new List<SubmissionEntity>();
                            AllSubmissions.Add(sub);

                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;

                }


            }
            return AllSubmissions;
        }




        public void SaveFormA(AEntity aa, int year, int userId)
        {


            DataSet dsUsers = new DataSet();
            SpParamCollection spParams = new SpParamCollection();
            sqlConn = new SqlConnection(m_connectionString);

            spParams.Add(new SpParam("@Name", aa.Name));
            spParams.Add(new SpParam("@Designation", aa.Designation));
            spParams.Add(new SpParam("@Institute", aa.Institute));
            spParams.Add(new SpParam("@villagename", aa.Village));
            spParams.Add(new SpParam("@tehsilname", aa.Tehsil));
            spParams.Add(new SpParam("@districtname", aa.District));
            spParams.Add(new SpParam("@cityname", aa.City));
            spParams.Add(new SpParam("@statename", aa.State));
            spParams.Add(new SpParam("@pincode", aa.PinCode));

            spParams.Add(new SpParam("@description", aa.OtherDetails));

            spParams.Add(new SpParam("@presentvalue", aa.CurrentValue));

            spParams.Add(new SpParam("@if_notown_name", aa.OwnName.ToString()));
            spParams.Add(new SpParam("@whosename", aa.OwnerName));
            spParams.Add(new SpParam("@relationship", aa.OwnerRelation));
            spParams.Add(new SpParam("@purchasedetails", aa.HowAcquired.ToString()));
            spParams.Add(new SpParam("@person_whom_acquired", aa.AcquiredFrom));
            spParams.Add(new SpParam("@purchase_date", aa.AcquiredDate));

            spParams.Add(new SpParam("@funding_details", aa.FundingSource));
            spParams.Add(new SpParam("@annual_income", aa.AnnualIncome));
            spParams.Add(new SpParam("@remarks", aa.OtherDetails));

            spParams.Add(new SpParam("@year", year));

            spParams.Add(new SpParam("@userId", userId));

            DBHelper.ExecProcNonQuery("SaveFormA", spParams, sqlConn);
        }



        public void SaveFormB(BEntity bb, int year, int userId)
        {


            DataSet dsUsers = new DataSet();
            SpParamCollection spParams = new SpParamCollection();
            sqlConn = new SqlConnection(m_connectionString);


            spParams.Add(new SpParam("@userID", userId));


            spParams.Add(new SpParam("@shares_lastyear_totalno", bb.LastYearSharesNo));
            spParams.Add(new SpParam("@shares_lastyear_facevalue", bb.LastYearSharesValue));
            spParams.Add(new SpParam("@shares_lastyear_costofacquisition ", bb.LastyearSharesCostofacquisition));
            spParams.Add(new SpParam("@shares_currentyear_totalno", bb.CurrentYearSharesNo));
            spParams.Add(new SpParam("@shares_currentyear_facevalue ", bb.CurrentYearSharesValue));
            spParams.Add(new SpParam("@shares_currentyear_costofacquisition ", bb.CurrentyearSharesCostofacquisition));
            spParams.Add(new SpParam("@shares_costofacquisition_thisyear ", bb.ThisyearSharesCostofacquisition));
            spParams.Add(new SpParam("@shares_sourceof_funding", bb.SharesFundingSource));

            spParams.Add(new SpParam("@debenture_lastyear_totalno", bb.LastYearDebenturesNo));
            spParams.Add(new SpParam("@debenture_lastyear_facevalue", bb.LastYearDebenturesValue));
            spParams.Add(new SpParam("@debenture_lastyear_costofacquisition", bb.LastyearDebenturesCostofacquisition));
            spParams.Add(new SpParam("@debenture_currentyear_totalno", bb.CurrentYearDebenturesNo));
            spParams.Add(new SpParam("@debenture_currentyear_facevalue", bb.CurrentYearDebenturesValue));
            spParams.Add(new SpParam("@debenture_currentyear_costofacquisition", bb.CurrentyearDebenturesCostofacquisition));
            spParams.Add(new SpParam("@debenture_costofacquisition_thisyear", bb.ThisyearDebenturesCostofacquisition));
            spParams.Add(new SpParam("@debenture_sourceof_funding", bb.DebenturesFundingSource));


            spParams.Add(new SpParam("@units_lastyear_totalno", bb.LastYearUnitsNo));
            spParams.Add(new SpParam("@units_lastyear_facevalue ", bb.LastYearUnitsValue));
            spParams.Add(new SpParam("@units_lastyear_costofacquisition ", bb.LastyearUnitsCostofacquisition));
            spParams.Add(new SpParam("@units_currentyear_totalno", bb.CurrentYearUnitsNo));
            spParams.Add(new SpParam("@units_currentyear_facevalue ", bb.CurrentYearUnitsValue));
            spParams.Add(new SpParam("@units_currentyear_costofacquisition ", bb.CurrentyearUnitsCostofacquisition));
            spParams.Add(new SpParam("@units_costofacquisition_thisyear ", bb.ThisyearUnitsCostofacquisition));
            spParams.Add(new SpParam("@units_sourceof_funding", bb.UnitsFundingSource));

            spParams.Add(new SpParam("@nscs_lastyear_totalno", bb.LastYearNSCNo));
            spParams.Add(new SpParam("@nscs_lastyear_facevalue ", bb.LastYearNSCValue));
            spParams.Add(new SpParam("@nscs_lastyear_costofacquisition ", bb.LastyearNSCCostofacquisition));
            spParams.Add(new SpParam("@nscs_currentyear_totalno", bb.CurrentYearNSCNo));
            spParams.Add(new SpParam("@nscs_currentyear_facevalue ", bb.CurrentYearNSCValue));
            spParams.Add(new SpParam("@nscs_currentyear_costofacquisition ", bb.CurrentyearNSCCostofacquisition));
            spParams.Add(new SpParam("@nscs_costofacquisition_thisyear ", bb.ThisyearNSCCostofacquisition));
            spParams.Add(new SpParam("@nscs_sourceof_funding", bb.NSCFundingSource));

            spParams.Add(new SpParam("@nss_lastyear_totalno", bb.LastYearNSSNo));
            spParams.Add(new SpParam("@nss_lastyear_facevalue ", bb.LastYearNSSValue));
            spParams.Add(new SpParam("@nss_lastyear_costofacquisition ", bb.LastyearNSSCostofacquisition));
            spParams.Add(new SpParam("@nss_current_totalno", bb.CurrentYearNSSNo));
            spParams.Add(new SpParam("@nss_current_facevalue ", bb.CurrentYearNSSValue));
            spParams.Add(new SpParam("@nss_current_Costofacquisition ", bb.CurrentyearNSSCostofacquisition));
            spParams.Add(new SpParam("@nss_Costofacquisition_thisyear ", bb.ThisyearNSSCostofacquisition));
            spParams.Add(new SpParam("@nss_sourceof_funding  ", bb.NSSFundingSource));

            spParams.Add(new SpParam("@allbank_lastyear_totalno", bb.LastYearDepositsNo));
            spParams.Add(new SpParam("@allbank_lastyear_facevalue ", bb.LastYearDepositsValue));
            spParams.Add(new SpParam("@allbank_lastyear_costofacquisition ", bb.LastyearDepositsCostofacquisition));
            spParams.Add(new SpParam("@allbank_currentyear_totalno", bb.CurrentYearDepositsNo));
            spParams.Add(new SpParam("@allbank_currentyear_facevalue ", bb.CurrentYearDepositsValue));
            spParams.Add(new SpParam("@allbank_currentyear_costofacquisition ", bb.CurrentyearDepositsCostofacquisition));
            spParams.Add(new SpParam("@allbank_costofacquisition_thisyear ", bb.ThisyearDepositsCostofacquisition));
            spParams.Add(new SpParam("@allbank_sourceof_funding", bb.DepositsFundingSource));


            spParams.Add(new SpParam("@othersecurity_lastyear_totalno", bb.LastYearBondsNo));
            spParams.Add(new SpParam("@othersecurity_lastyear_facevalue ", bb.LastYearBondsValue));
            spParams.Add(new SpParam("@othersecurity_lastyear_costofacquisition ", bb.LastyearBondsCostofacquisition));
            spParams.Add(new SpParam("@othersecurity_currentyear_totalno", bb.CurrentYearBondsNo));
            spParams.Add(new SpParam("@othersecurity_currentyear_facevalue ", bb.CurrentYearBondsValue));
            spParams.Add(new SpParam("@othersecurity_currentyear_costofacquisition ", bb.CurrentyearBondsCostofacquisition));
            spParams.Add(new SpParam("@othersecurity_costofacquisition_thisyear ", bb.ThisyearBondsCostofacquisition));
            spParams.Add(new SpParam("@othersecurity_sourceof_funding", bb.BondsFundingSource));


            spParams.Add(new SpParam("@allother_lastyear_totalno", bb.LastYearBondsNo));
            spParams.Add(new SpParam("@allother_lastyear_facevalue ", bb.LastYearBondsValue));
            spParams.Add(new SpParam("@allother_lastyear_costofacquisition ", bb.LastyearBondsCostofacquisition));
            spParams.Add(new SpParam("@allother_currentyear_totalno", bb.CurrentYearBondsNo));
            spParams.Add(new SpParam("@allother_currentyear_facevalue", bb.CurrentYearBondsValue));
            spParams.Add(new SpParam("@allother_currentyear_costofacquisition", bb.CurrentyearBondsCostofacquisition));
            spParams.Add(new SpParam("@allother_costofacquisition_thisyear ", bb.ThisyearBondsCostofacquisition));
            spParams.Add(new SpParam("@allother_sourceof_funding", bb.OthersFundingSource));
            spParams.Add(new SpParam("@year", year));




            DBHelper.ExecProcNonQuery("SaveFormB", spParams, sqlConn);

        }


        public void SaveFormC(CEntity cc, int year, int userId)
        {


            DataSet dsUsers = new DataSet();
            SpParamCollection spParams = new SpParamCollection();
            sqlConn = new SqlConnection(m_connectionString);


            spParams.Add(new SpParam("@userID", userId));

            spParams.Add(new SpParam("@shares_script_description", cc.shares_script_description));
            spParams.Add(new SpParam("@shares_facevalue", cc.shares_facevalue));
            spParams.Add(new SpParam("@shares_purchase_consideration", cc.shares_purchase_consideration));
            spParams.Add(new SpParam("@shares_howacquired", cc.shares_howacquired));
            spParams.Add(new SpParam("@shares_relationship", cc.shares_relationship));
            spParams.Add(new SpParam("@debenture_script_description", cc.debenture_script_description));
            spParams.Add(new SpParam("@debenture_facevalue", cc.debenture_facevalue));
            spParams.Add(new SpParam("@debenture_purchase_consideration", cc.debenture_purchase_consideration));
            spParams.Add(new SpParam("@debenture_howacquired", cc.debenture_howacquired));
            spParams.Add(new SpParam("@debenture_relationship", cc.debenture_relationship));
            spParams.Add(new SpParam("@units_script_description", cc.units_script_description));
            spParams.Add(new SpParam("@units_facevalue", cc.units_facevalue));
            spParams.Add(new SpParam("@units_purchase_consideration", cc.units_purchase_consideration));
            spParams.Add(new SpParam("@units_howacquired", cc.units_howacquired));
            spParams.Add(new SpParam("@units_relationship", cc.units_relationship));
            spParams.Add(new SpParam("@nscs_script_description", cc.nscs_script_description));
            spParams.Add(new SpParam("@nscs_facevalue", cc.nscs_facevalue));
            spParams.Add(new SpParam("@nscs_purchase_consideration", cc.nscs_purchase_consideration));
            spParams.Add(new SpParam("@nscs_howacquired", cc.nscs_howacquired));
            spParams.Add(new SpParam("@nscs_relationship", cc.nscs_relationship));
            spParams.Add(new SpParam("@nss_script_description", cc.nss_script_description));
            spParams.Add(new SpParam("@nss_facevalue", cc.nss_facevalue));
            spParams.Add(new SpParam("@nss_purchase_consideration", cc.nss_purchase_consideration));
            spParams.Add(new SpParam("@nss_howacquired", cc.nss_howacquired));
            spParams.Add(new SpParam("@nss_relationship", cc.nss_relationship));
            spParams.Add(new SpParam("@allbank_script_description", cc.allbank_script_description));
            spParams.Add(new SpParam("@allbank_facevalue", cc.allbank_facevalue));
            spParams.Add(new SpParam("@allbank_purchase_consideration", cc.allbank_purchase_consideration));
            spParams.Add(new SpParam("@allbank_howacquired", cc.allbank_howacquired));
            spParams.Add(new SpParam("@allbank_relationship", cc.allbank_relationship));
            spParams.Add(new SpParam("@othersecurity_script_description", cc.othersecurity_script_description));
            spParams.Add(new SpParam("@othersecurity_facevalue", cc.othersecurity_facevalue));
            spParams.Add(new SpParam("@othersecurity_purchase_consideration", cc.othersecurity_purchase_consideration));
            spParams.Add(new SpParam("@othersecurity_howacquired", cc.othersecurity_howacquired));
            spParams.Add(new SpParam("@othersecurity_relationship", cc.othersecurity_relationship));
            spParams.Add(new SpParam("@allother_script_description", cc.allother_script_description));
            spParams.Add(new SpParam("@allother_facevalue", cc.allother_facevalue));
            spParams.Add(new SpParam("@allother_purchase_consideration", cc.allother_purchase_consideration));
            spParams.Add(new SpParam("@allother_howacquired", cc.allother_howacquired));
            spParams.Add(new SpParam("@allother_relationship", cc.allother_relationship));
            spParams.Add(new SpParam("@year", year));




            DBHelper.ExecProcNonQuery("SaveFormC", spParams, sqlConn);




        }

        public void SaveFormD(DEntity dd, int year, int userId)
        {

            DataSet dsUsers = new DataSet();
            SpParamCollection spParams = new SpParamCollection();
            sqlConn = new SqlConnection(m_connectionString);


            spParams.Add(new SpParam("@userID", userId));
            spParams.Add(new SpParam("@year", year));




            DBHelper.ExecProcNonQuery("SaveFormD", spParams, sqlConn);

        }

    }
}