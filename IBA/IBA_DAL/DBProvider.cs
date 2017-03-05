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

        public AEntity GetFormAData(int year, int userId)
        {
            AEntity formA = null;

            DataSet dsFormA = new DataSet();
            SpParamCollection spParams = new SpParamCollection();
            sqlConn = new SqlConnection(m_connectionString);
            spParams.Add(new SpParam("@userId", userId));
            spParams.Add(new SpParam("@Year", year));



            DBHelper.ExecProcAndFillDataSet("GetFormAData", spParams, dsFormA, sqlConn);

            if (dsFormA != null && dsFormA.Tables.Count > 0)
            {
                try
                {
                    DataTable dtFormA = dsFormA.Tables[0];

                    if (dtFormA != null && dtFormA.Rows.Count > 0)
                    {
                        DataRow drFormA = dtFormA.Rows[0];
                        formA = new AEntity();


                        formA.Name = Utils.GetStringValue(drFormA["name"]);
                        formA.Designation = Utils.GetStringValue(drFormA["designation"]);
                        formA.Institute = Utils.GetStringValue(drFormA["institute"]);
                        formA.Village = Utils.GetStringValue(drFormA["villagename"]);
                        formA.Tehsil = Utils.GetStringValue(drFormA["tehsilname"]);
                        formA.District = Utils.GetStringValue(drFormA["districtname"]);
                        formA.City = Utils.GetStringValue(drFormA["cityname"]);
                        formA.State = Utils.GetStringValue(drFormA["statename"]);
                        formA.PinCode = Utils.GetStringValue(drFormA["pincode"]);

                        formA.OtherDetails = Utils.GetStringValue(drFormA["description"]);

                        formA.CurrentValue = Utils.GetDoubleValue(drFormA["presentvalue"]);

                        formA.OwnName = Utils.GetBoolValue(drFormA["if_notown_name"]);
                        formA.OwnerName = Utils.GetStringValue(drFormA["whosename"]);
                        formA.OwnerRelation = Utils.GetStringValue(drFormA["relationship"]);
                        formA.HowAcquired = (Constants.HowAcquired)Enum.Parse(typeof(Constants.HowAcquired), drFormA["purchasedetails"].ToString());
                        formA.AcquiredFrom = Utils.GetStringValue(drFormA["person_whom_acquired"]);
                        formA.AcquiredDate = Utils.GetDateTimeValue(drFormA["purchase_date"]).Value;

                        formA.FundingSource = Utils.GetStringValue(drFormA["funding_details"]);
                        formA.AnnualIncome = Utils.GetDoubleValue(drFormA["annual_income"]);
                        formA.OtherDetails = Utils.GetStringValue(drFormA["remarks"]);


                    }
                }
                catch (Exception ex)
                {
                    throw ex;

                }


            }
            return formA;


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


        public BEntity GetFormBData(int year, int userId)
        {
            BEntity formB = null;

            DataSet dsFormB = new DataSet();
            SpParamCollection spParams = new SpParamCollection();
            sqlConn = new SqlConnection(m_connectionString);
            spParams.Add(new SpParam("@userId", userId));
            spParams.Add(new SpParam("@Year", year));



            DBHelper.ExecProcAndFillDataSet("GetFormBData", spParams, dsFormB, sqlConn);

            if (dsFormB != null && dsFormB.Tables.Count > 0)
            {
                try
                {
                    DataTable dtFormA = dsFormB.Tables[0];

                    if (dtFormA != null && dtFormA.Rows.Count > 0)
                    {
                        DataRow drFormA = dtFormA.Rows[0];
                        formB = new BEntity();


                        formB.LastYearSharesNo = Utils.GetIntValue(drFormA["shares_lastyear_totalno"]);
                        formB.LastYearSharesValue = Utils.GetDoubleValue(drFormA["shares_lastyear_facevalue"]);
                        formB.LastyearSharesCostofacquisition = Utils.GetDoubleValue(drFormA["shares_lastyear_costofacquisition"]);
                        formB.CurrentYearSharesNo = Utils.GetIntValue(drFormA["shares_currentyear_totalno"]);
                        formB.CurrentYearSharesValue = Utils.GetDoubleValue(drFormA["shares_currentyear_facevalue"]);
                        formB.CurrentyearSharesCostofacquisition = Utils.GetDoubleValue(drFormA["shares_currentyear_costofacquisition"]);
                        formB.ThisyearSharesCostofacquisition = Utils.GetDoubleValue(drFormA["shares_costofacquisition_thisyear"]);
                        formB.SharesFundingSource = Utils.GetStringValue(drFormA["SharesFundingSource"]);


                        formB.LastYearDebenturesNo = Utils.GetIntValue(drFormA["Debentures_lastyear_totalno"]);
                        formB.LastYearDebenturesValue = Utils.GetDoubleValue(drFormA["Debentures_lastyear_facevalue"]);
                        formB.LastyearDebenturesCostofacquisition = Utils.GetDoubleValue(drFormA["Debentures_lastyear_costofacquisition"]);
                        formB.CurrentYearDebenturesNo = Utils.GetIntValue(drFormA["Debentures_currentyear_totalno"]);
                        formB.CurrentYearDebenturesValue = Utils.GetDoubleValue(drFormA["Debentures_currentyear_facevalue"]);
                        formB.CurrentyearDebenturesCostofacquisition = Utils.GetDoubleValue(drFormA["Debentures_currentyear_costofacquisition"]);
                        formB.ThisyearDebenturesCostofacquisition = Utils.GetDoubleValue(drFormA["Debentures_costofacquisition_thisyear"]);
                        formB.DebenturesFundingSource = Utils.GetStringValue(drFormA["DebenturesFundingSource"]);


                        formB.LastYearUnitsNo = Utils.GetIntValue(drFormA["Units_lastyear_totalno"]);
                        formB.LastYearUnitsValue = Utils.GetDoubleValue(drFormA["Units_lastyear_facevalue"]);
                        formB.LastyearUnitsCostofacquisition = Utils.GetDoubleValue(drFormA["Units_lastyear_costofacquisition"]);
                        formB.CurrentYearUnitsNo = Utils.GetIntValue(drFormA["Units_currentyear_totalno"]);
                        formB.CurrentYearUnitsValue = Utils.GetDoubleValue(drFormA["Units_currentyear_facevalue"]);
                        formB.CurrentyearUnitsCostofacquisition = Utils.GetDoubleValue(drFormA["Units_currentyear_costofacquisition"]);
                        formB.ThisyearUnitsCostofacquisition = Utils.GetDoubleValue(drFormA["Units_costofacquisition_thisyear"]);
                        formB.UnitsFundingSource = Utils.GetStringValue(drFormA["UnitsFundingSource"]);


                        formB.LastYearNSCNo = Utils.GetIntValue(drFormA["NSC_lastyear_totalno"]);
                        formB.LastYearNSCValue = Utils.GetDoubleValue(drFormA["NSC_lastyear_facevalue"]);
                        formB.LastyearNSCCostofacquisition = Utils.GetDoubleValue(drFormA["NSC_lastyear_costofacquisition"]);
                        formB.CurrentYearNSCNo = Utils.GetIntValue(drFormA["NSC_currentyear_totalno"]);
                        formB.CurrentYearNSCValue = Utils.GetDoubleValue(drFormA["NSC_currentyear_facevalue"]);
                        formB.CurrentyearNSCCostofacquisition = Utils.GetDoubleValue(drFormA["NSC_currentyear_costofacquisition"]);
                        formB.ThisyearNSCCostofacquisition = Utils.GetDoubleValue(drFormA["NSC_costofacquisition_thisyear"]);
                        formB.NSCFundingSource = Utils.GetStringValue(drFormA["NSCFundingSource"]);



                        formB.LastYearNSSNo = Utils.GetIntValue(drFormA["NSS_lastyear_totalno"]);
                        formB.LastYearNSSValue = Utils.GetDoubleValue(drFormA["NSS_lastyear_facevalue"]);
                        formB.LastyearNSSCostofacquisition = Utils.GetDoubleValue(drFormA["NSS_lastyear_costofacquisition"]);
                        formB.CurrentYearNSSNo = Utils.GetIntValue(drFormA["NSS_currentyear_totalno"]);
                        formB.CurrentYearNSSValue = Utils.GetDoubleValue(drFormA["NSS_currentyear_facevalue"]);
                        formB.CurrentyearNSSCostofacquisition = Utils.GetDoubleValue(drFormA["NSS_currentyear_costofacquisition"]);
                        formB.ThisyearNSSCostofacquisition = Utils.GetDoubleValue(drFormA["NSS_costofacquisition_thisyear"]);
                        formB.NSSFundingSource = Utils.GetStringValue(drFormA["NSSFundingSource"]);


                        formB.LastYearBondsNo = Utils.GetIntValue(drFormA["Bonds_lastyear_totalno"]);
                        formB.LastYearBondsValue = Utils.GetDoubleValue(drFormA["Bonds_lastyear_facevalue"]);
                        formB.LastyearBondsCostofacquisition = Utils.GetDoubleValue(drFormA["Bonds_lastyear_costofacquisition"]);
                        formB.CurrentYearBondsNo = Utils.GetIntValue(drFormA["Bonds_currentyear_totalno"]);
                        formB.CurrentYearBondsValue = Utils.GetDoubleValue(drFormA["Bonds_currentyear_facevalue"]);
                        formB.CurrentyearBondsCostofacquisition = Utils.GetDoubleValue(drFormA["Bonds_currentyear_costofacquisition"]);
                        formB.ThisyearBondsCostofacquisition = Utils.GetDoubleValue(drFormA["Bonds_costofacquisition_thisyear"]);
                        formB.BondsFundingSource = Utils.GetStringValue(drFormA["BondsFundingSource"]);

                        formB.LastYearDepositsNo = Utils.GetIntValue(drFormA["Deposits_lastyear_totalno"]);
                        formB.LastYearDepositsValue = Utils.GetDoubleValue(drFormA["Deposits_lastyear_facevalue"]);
                        formB.LastyearDepositsCostofacquisition = Utils.GetDoubleValue(drFormA["Deposits_lastyear_costofacquisition"]);
                        formB.CurrentYearDepositsNo = Utils.GetIntValue(drFormA["Deposits_currentyear_totalno"]);
                        formB.CurrentYearDepositsValue = Utils.GetDoubleValue(drFormA["Deposits_currentyear_facevalue"]);
                        formB.CurrentyearDepositsCostofacquisition = Utils.GetDoubleValue(drFormA["Deposits_currentyear_costofacquisition"]);
                        formB.ThisyearDepositsCostofacquisition = Utils.GetDoubleValue(drFormA["Deposits_costofacquisition_thisyear"]);
                        formB.DepositsFundingSource = Utils.GetStringValue(drFormA["DepositsFundingSource"]);


                        formB.LastYearOthersNo = Utils.GetIntValue(drFormA["Others_lastyear_totalno"]);
                        formB.LastYearOthersValue = Utils.GetDoubleValue(drFormA["Others_lastyear_facevalue"]);
                        formB.LastyearOthersCostofacquisition = Utils.GetDoubleValue(drFormA["Others_lastyear_costofacquisition"]);
                        formB.CurrentYearOthersNo = Utils.GetIntValue(drFormA["Others_currentyear_totalno"]);
                        formB.CurrentYearOthersValue = Utils.GetDoubleValue(drFormA["Others_currentyear_facevalue"]);
                        formB.CurrentyearOthersCostofacquisition = Utils.GetDoubleValue(drFormA["Others_currentyear_costofacquisition"]);
                        formB.ThisyearOthersCostofacquisition = Utils.GetDoubleValue(drFormA["Others_costofacquisition_thisyear"]);
                        formB.OthersFundingSource = Utils.GetStringValue(drFormA["OthersFundingSource"]);

                    }
                }
                catch (Exception ex)
                {
                    throw ex;

                }


            }
            return formB;


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


        public CEntity GetFormCData(int year, int userId)
        {
            CEntity formC = null;

            DataSet dsFormB = new DataSet();
            SpParamCollection spParams = new SpParamCollection();
            sqlConn = new SqlConnection(m_connectionString);
            spParams.Add(new SpParam("@userId", userId));
            spParams.Add(new SpParam("@Year", year));



            DBHelper.ExecProcAndFillDataSet("GetFormCData", spParams, dsFormB, sqlConn);

            if (dsFormB != null && dsFormB.Tables.Count > 0)
            {
                try
                {
                    DataTable dtFormA = dsFormB.Tables[0];

                    if (dtFormA != null && dtFormA.Rows.Count > 0)
                    {
                        DataRow drFormA = dtFormA.Rows[0];
                        formC = new CEntity();


                        formC.shares_script_description = Utils.GetStringValue(drFormA["shares_script_description"]);
                        formC.shares_facevalue = Utils.GetDoubleValue(drFormA["shares_facevalue"]);
                        formC.shares_purchase_consideration = Utils.GetDoubleValue(drFormA["shares_purchase_consideration"]);
                        formC.shares_howacquired = Utils.GetStringValue(drFormA["shares_howacquired"]);
                        formC.shares_relationship = Utils.GetStringValue(drFormA["shares_relationship"]);

                        formC.debenture_script_description = Utils.GetStringValue(drFormA["debenture_script_description"]);
                        formC.debenture_facevalue = Utils.GetDoubleValue(drFormA["debenture_facevalue"]);
                        formC.debenture_purchase_consideration = Utils.GetDoubleValue(drFormA["debenture_purchase_consideration"]);
                        formC.debenture_howacquired = Utils.GetStringValue(drFormA["debenture_howacquired"]);
                        formC.debenture_relationship = Utils.GetStringValue(drFormA["debenture_relationship"]);

                        formC.units_script_description = Utils.GetStringValue(drFormA["units_script_description"]);
                        formC.units_facevalue = Utils.GetDoubleValue(drFormA["units_facevalue"]);
                        formC.units_purchase_consideration = Utils.GetDoubleValue(drFormA["units_purchase_consideration"]);
                        formC.units_howacquired = Utils.GetStringValue(drFormA["shares_howacquired"]);
                        formC.units_relationship = Utils.GetStringValue(drFormA["units_relationship"]);

                        formC.nscs_script_description = Utils.GetStringValue(drFormA["nscs_script_description"]);
                        formC.nscs_facevalue = Utils.GetDoubleValue(drFormA["nscs_facevalue"]);
                        formC.nscs_purchase_consideration = Utils.GetDoubleValue(drFormA["nscs_purchase_consideration"]);
                        formC.nscs_howacquired = Utils.GetStringValue(drFormA["nscs_howacquired"]);
                        formC.nscs_relationship = Utils.GetStringValue(drFormA["nscs_relationship"]);

                        formC.nss_script_description = Utils.GetStringValue(drFormA["nss_script_description"]);
                        formC.nss_facevalue = Utils.GetDoubleValue(drFormA["nss_facevalue"]);
                        formC.nss_purchase_consideration = Utils.GetDoubleValue(drFormA["nss_purchase_consideration"]);
                        formC.nss_howacquired = Utils.GetStringValue(drFormA["nss_howacquired"]);
                        formC.nss_relationship = Utils.GetStringValue(drFormA["nss_relationship"]);



                        formC.allbank_script_description = Utils.GetStringValue(drFormA["allbank_script_description"]);
                        formC.allbank_facevalue = Utils.GetDoubleValue(drFormA["allbank_facevalue"]);
                        formC.allbank_purchase_consideration = Utils.GetDoubleValue(drFormA["allbank_purchase_consideration"]);
                        formC.allbank_howacquired = Utils.GetStringValue(drFormA["allbank_howacquired"]);
                        formC.allbank_relationship = Utils.GetStringValue(drFormA["allbank_relationship"]);

                        formC.othersecurity_script_description = Utils.GetStringValue(drFormA["othersecurity_script_description"]);
                        formC.othersecurity_facevalue = Utils.GetDoubleValue(drFormA["othersecurity_facevalue"]);
                        formC.othersecurity_purchase_consideration = Utils.GetDoubleValue(drFormA["othersecurity_purchase_consideration"]);
                        formC.othersecurity_howacquired = Utils.GetStringValue(drFormA["othersecurity_howacquired"]);
                        formC.othersecurity_relationship = Utils.GetStringValue(drFormA["othersecurity_relationship"]);

                        formC.allother_script_description = Utils.GetStringValue(drFormA["allother_script_description"]);
                        formC.allother_facevalue = Utils.GetDoubleValue(drFormA["allother_facevalue"]);
                        formC.allother_purchase_consideration = Utils.GetDoubleValue(drFormA["allother_purchase_consideration"]);
                        formC.allother_howacquired = Utils.GetStringValue(drFormA["allother_howacquired"]);
                        formC.allother_relationship = Utils.GetStringValue(drFormA["allother_relationship"]);

                    }
                }
                catch (Exception ex)
                {
                    throw ex;

                }


            }
            return formC;


        }






        public void SaveFormD(DEntity dd, int year, int userId)
        {

            DataSet dsUsers = new DataSet();
            SpParamCollection spParams = new SpParamCollection();
            sqlConn = new SqlConnection(m_connectionString);


            spParams.Add(new SpParam("@userID", userId));
            spParams.Add(new SpParam("@year", year));
            spParams.Add(new SpParam("@LoanFriends", dd.LoanFriends));
            spParams.Add(new SpParam("@LoanSecurity", dd.LoanSecurity));
            spParams.Add(new SpParam("@OtherLiabilities", dd.OtherLiability));



            DBHelper.ExecProcNonQuery("SaveFormD", spParams, sqlConn);

        }

        public DEntity GetFormDData(int year, int userId)
        {
            DEntity formD = null;

            DataSet dsFormD = new DataSet();
            SpParamCollection spParams = new SpParamCollection();
            sqlConn = new SqlConnection(m_connectionString);
            spParams.Add(new SpParam("@userId", userId));
            spParams.Add(new SpParam("@Year", year));



            DBHelper.ExecProcAndFillDataSet("GetFormDData", spParams, dsFormD, sqlConn);

            if (dsFormD != null && dsFormD.Tables.Count > 0)
            {
                try
                {
                    DataTable dtFormA = dsFormD.Tables[0];

                    if (dtFormA != null && dtFormA.Rows.Count > 0)
                    {
                        DataRow drFormA = dtFormA.Rows[0];
                        formD = new DEntity();

                        formD.LoanFriends = Utils.GetDoubleValue(drFormA["loansfrom_friend_relative"]);
                        formD.LoanSecurity = Utils.GetDoubleValue(drFormA["loanagainst_securities_frombank"]);
                        formD.OtherLiability = Utils.GetStringValue(drFormA["anyother_liability"]);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;

                }


            }
            return formD;


        }







    }
}