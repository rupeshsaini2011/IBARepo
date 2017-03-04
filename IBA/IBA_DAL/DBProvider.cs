using IBAEntities;
using System;
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



        public SubmissionEntity GetSubmissionByUser(int userId)
        {
            SubmissionEntity sub = null;

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
                        DataRow drUser = dtSubmission.Rows[0];
                        sub = new SubmissionEntity();
                        sub.SubmissionId = Utils.GetIntValue(drUser["Id"]);
                        sub.SubmissionYear = Utils.GetIntValue(drUser["year"]);
                        sub.SubmissionDate = Utils.GetDateTimeValue(drUser["create_at"].ToString()).Value;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;

                }


            }
            return sub;
        }





    }
}