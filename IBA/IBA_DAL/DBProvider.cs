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

        public void SaveFormA(AEntity aa)
        {
            

            DataSet dsUsers = new DataSet();
            SpParamCollection spParams = new SpParamCollection();
            sqlConn = new SqlConnection(m_connectionString);






            spParams.Add(new SpParam("@Name", aa.Name ));
            spParams.Add(new SpParam("@Designation", aa.Designation));
            spParams.Add(new SpParam("@Institute", aa.Institute));
            spParams.Add(new SpParam("@Village", aa.Village));
            spParams.Add(new SpParam("@Tehsil", aa.Tehsil));
            spParams.Add(new SpParam("@District", aa.District ));
            spParams.Add(new SpParam("@City", aa.City ));
            spParams.Add(new SpParam("@State", aa.State ));
            spParams.Add(new SpParam("@PinCode", aa.PinCode ));

            spParams.Add(new SpParam("@OtherDetails", aa.OtherDetails ));

            spParams.Add(new SpParam("@CurrentValue", aa.CurrentValue));

            spParams.Add(new SpParam("@OwnName", aa.OwnName ));
            spParams.Add(new SpParam("@OwnerName", aa.OwnerName));
            spParams.Add(new SpParam("@OwnerRelation", aa.OwnerRelation ));
            spParams.Add(new SpParam("@HowAcquired", aa.HowAcquired ));
            spParams.Add(new SpParam("@AcquiredFrom", aa.AcquiredFrom ));
            spParams.Add(new SpParam("@AcquiredDate", aa.AcquiredDate ));

            spParams.Add(new SpParam("@FundingSource", aa.FundingSource ));
            spParams.Add(new SpParam("@AnnualIncome", aa.AnnualIncome ));
            spParams.Add(new SpParam("@OtherDetails", aa.OtherDetails));



            DBHelper.ExecProcNonQuery("RE_CreateNewApp", spParams, sqlConn);
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

                            if (!String.IsNullOrEmpty(Utils.GetStringValue(drSubmission["form1id"])))
                                sub.SubmittedForms.Add(Constants.FORMA);
                            if (!String.IsNullOrEmpty(Utils.GetStringValue(drSubmission["form2id"])))
                                sub.SubmittedForms.Add(Constants.FORMB);
                            if (!String.IsNullOrEmpty(Utils.GetStringValue(drSubmission["form3id"])))
                                sub.SubmittedForms.Add(Constants.FORMC);
                            if (!String.IsNullOrEmpty(Utils.GetStringValue(drSubmission["form4id"])))
                                sub.SubmittedForms.Add(Constants.FORMD);
                       



                            if (AllSubmissions != null)
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





    }
}