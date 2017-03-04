/*************************************************************************/
/****** This class provides easy way to access data with helpful *********/
/****** methods to create parameters list and execute stored procs *******/
/*************************************************************************/

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Xml;

namespace IBA_DAL
{
    #region Structs

    /// <summary>
    /// Represents a stored procedure's command paramater 
    /// name/value pair and the direction of the parameter
    /// </summary>
    public struct SpParam
    {
        private string m_paramName;
        private object m_paramValue;
        private bool m_paramDirectionOut;

        public string Name
        {
            get { return m_paramName; }
        }

        public object Value
        {
            get { return m_paramValue; }
        }

        public bool ParamDirectionOut
        {
            get { return m_paramDirectionOut; }
            set { m_paramDirectionOut = value; }
        }

        /// <summary>
        /// Overridden constructor that sets the paramDirectionOut parameter to false
        /// </summary>
        /// <param name="paramName"></param>
        /// <param name="paramValue"></param>
        public SpParam(string paramName, object paramValue) : this(paramName, paramValue, false) { }

        /// <summary>
        /// Constructor that sets paramDirectionOut parameter specifically
        /// </summary>
        /// <param name="paramName"></param>
        /// <param name="paramValue"></param>
        /// <param name="paramDirectionOut"></param>
        public SpParam(string paramName, object paramValue, bool paramDirectionOut)
        {
            m_paramName = paramName;
            m_paramValue = paramValue;
            m_paramDirectionOut = paramDirectionOut;
        }
    }

    #endregion

    /// <summary>
    /// Represents a collection of parameters (SpParams').
    /// </summary>
    public class SpParamCollection : ArrayList
    {
        public SpParamCollection()
        {
        }

        public void Add(SpParam param)
        {
            base.Add(param);
        }
        public void clear()
        {
            base.Clear();
        }

    }

    /// <summary>
    /// Set of helper methods for calling and retrieving data from SQL stored procs.
    /// </summary>
    public class DBHelper
    {

        #region Constants

        private static int SQL_DEADLOCK_ERROR_NUM = 1205;

        #endregion

      
       


        #region Properties

        private static string m_connectionString;

        public static string DefaultConnectionString
        {
            get
            {
                return m_connectionString;
            }
            set
            {
                m_connectionString = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Private ctor to prevent compiler from generating public one
        /// </summary>
        static DBHelper()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Execute the given stored procedure. No results are expected from the proc.
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="spParams"></param>
        public static void ExecProcNonQuery(string procName, SpParamCollection spParams, SqlConnection conn)
        {
            SqlCommand command = new SqlCommand(procName, conn);

            try
            {
                InflateCommandObject(spParams, command);
                conn.Open();
                command.CommandTimeout = 0;
                command.ExecuteNonQuery();

            }
            catch (SqlException sqlEx)
            {
                if (SQL_DEADLOCK_ERROR_NUM == sqlEx.Number)
                {
                    try
                    {
                        //command.CommandTimeout=60; 
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    throw sqlEx;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command = null;
                if (null != conn)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        /// <summary>
        /// Overloaded method for ExecProcNonQuery that uses default sql connection
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="spParams"></param>
        public static void ExecProcNonQuery(string procName, SpParamCollection spParams)
        {
            ExecProcNonQuery(procName, spParams, GetConnection());
        }

        /// <summary>
        /// Execute the given stored procedure. Return command object to retrive out parameter value.
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="spParams"></param>
        /// code
        public static SqlCommand ExecProcNonQueryAndReturnCommand(string procName, SpParamCollection spParams, SqlConnection conn)
        {
            try
            {
                SqlCommand command = new SqlCommand(procName, conn);

                try
                {
                    InflateCommandObject(spParams, command);
                    conn.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqlEx)
                {
                    if (SQL_DEADLOCK_ERROR_NUM == sqlEx.Number)
                    {
                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                    else
                    {
                        throw sqlEx;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (null != conn)
                    {
                        conn.Close();
                        conn.Dispose();
                    }
                }
                return command;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Execute the given stored procedure. Return integer result.
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="spParams"></param>
        public static object ExecProcScalar(string procName, SpParamCollection spParams, SqlConnection conn)
        {
            SqlCommand command = new SqlCommand(procName, conn);
            object result = null;

            try
            {
                InflateCommandObject(spParams, command);
                conn.Open();
                result = command.ExecuteScalar();
            }
            catch (SqlException sqlEx)
            {
                if (SQL_DEADLOCK_ERROR_NUM == sqlEx.Number)
                {
                    try
                    {
                        result = command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    throw sqlEx;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command = null;
                if (null != conn)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }

            return result;
        }

        public static object ExecProcScalar(string procName, SpParamCollection spParams)
        {
            object result = ExecProcScalar(procName, spParams, GetConnection());
            return result;
        }

        public static SqlCommand ExecProcNonQueryAndReturnCommand(string procName, SpParamCollection spParams)
        {
            SqlCommand sqlCommand = new SqlCommand();
            return sqlCommand = ExecProcNonQueryAndReturnCommand(procName, spParams, GetConnection());
        }

        /// <summary>
        /// Execute the given stored procedure which is expected to return an xml document
        /// (using sql FOR XML clause), and then return that xml document.
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="spParams"></param>
        public static XmlDocument ExecProcAndReturnXmlDocument(string procName, SpParamCollection spParams, SqlConnection conn)
        {
            SqlCommand command = new SqlCommand(procName, conn);
            XmlDocument xmlDoc = null;

            try
            {
                InflateCommandObject(spParams, command);
                conn.Open();

                //Get XmlDocument
                XmlTextReader reader = (XmlTextReader)command.ExecuteXmlReader();
                xmlDoc = new XmlDocument();
                xmlDoc.Load(reader);
                reader.Close();
            }
            catch (SqlException sqlEx)
            {
                if (SQL_DEADLOCK_ERROR_NUM == sqlEx.Number)
                {
                    try
                    {
                        //Get XmlDocument
                        XmlTextReader reader = (XmlTextReader)command.ExecuteXmlReader();
                        xmlDoc = new XmlDocument();
                        xmlDoc.Load(reader);
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    throw sqlEx;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command = null;
                if (null != conn)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return xmlDoc;
        }

        /// <summary>
        /// Execute the given stored procedure and then populate the DataTable with the returned data.
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="spParams"></param>
        /// <param name="dt"></param>
        public static void ExecProcAndFillDataTable(string procName, SpParamCollection spParams, DataTable dt, SqlConnection conn)
        {
            SqlCommand command = new SqlCommand(procName, conn);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            try
            {
                InflateCommandObject(spParams, command);

                //Fill DataTable
                dt.Clear();
                dt.Rows.Clear();
                dataAdapter.Fill(dt);
            }
            catch (SqlException sqlEx)
            {
                if (SQL_DEADLOCK_ERROR_NUM == sqlEx.Number)
                {
                    try
                    {
                        dataAdapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    throw sqlEx;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command = null;
                if (null != conn)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        /// <summary>
        /// Overloaded method for ExecProcAndFillDataTable that uses the default connection
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="spParams"></param>
        /// <param name="dt"></param>
        /// <param name="conn"></param>
        private DataTable ExecProcAndFillDataTable(string procName, SpParamCollection spParams, DataTable dt)
        {
            ExecProcAndFillDataTable(procName, spParams, dt, GetConnection());
            return dt;
        }

        /// <summary>
        /// Execute the given stored procedure and then populate the DataSet with
        /// the returned data.
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="spParams"></param>
        /// <param name="ds"></param>
        public static void ExecProcAndFillDataSet(string procName, SpParamCollection spParams, DataSet ds, SqlConnection conn)
        {
            SqlCommand command = new SqlCommand(procName, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            try
            {
                InflateCommandObject(spParams, command);

                //Fill DataSet

                dataAdapter.Fill(ds);
            }
            catch (SqlException sqlEx)
            {
                if (SQL_DEADLOCK_ERROR_NUM == sqlEx.Number)
                {
                    try
                    {
                        dataAdapter.Fill(ds);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    throw sqlEx;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command = null;
                if (null != conn)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }
    
        
        public static void ExecProc(string procName, SpParamCollection spParams, DataSet ds, SqlConnection conn)
        {
            SqlCommand command = new SqlCommand(procName, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            try
            {
                InflateCommandObject(spParams, command);

                //Fill DataSet

                dataAdapter.Fill(ds);
            }
            catch (SqlException sqlEx)
            {
                if (SQL_DEADLOCK_ERROR_NUM == sqlEx.Number)
                {
                    try
                    {
                        dataAdapter.Fill(ds);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    throw sqlEx;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command = null;
                if (null != conn)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }


        /// <summary>
        /// Overloaded method for ExecProcAndFillDataSet that uses default sql connection
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="spParams"></param>
        /// <param name="ds"></param>
        public static void ExecProcAndFillDataSet(string procName, SpParamCollection spParams, DataSet ds)
        {
            ExecProcAndFillDataSet(procName, spParams, ds, GetConnection());
        }

        /// <summary>
        /// Execute the given stored procedure and then populate the DataReader with the data.
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="spParams"></param>
        /// <param name="dr"></param>
        public static void ExecProcAndPopulateDataReader(string procName, SpParamCollection spParams, out SqlDataReader dr, SqlConnection conn)
        {
            SqlCommand command = new SqlCommand(procName, conn);
            conn.Open();

            try
            {
                InflateCommandObject(spParams, command);
                dr = command.ExecuteReader();
            }
            catch (SqlException sqlEx)
            {
                if (SQL_DEADLOCK_ERROR_NUM == sqlEx.Number)
                {
                    try
                    {
                        dr = command.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    throw sqlEx;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Helper method to set properties of command object and its parameters
        /// </summary>
        /// <param name="spParams"></param>
        /// <param name="command"></param>
        private static void InflateCommandObject(SpParamCollection spParams, SqlCommand command)
        {
            command.CommandTimeout = 0;//Config.ExecuteTimeout;
            command.CommandType = CommandType.StoredProcedure;

            if (null == spParams) return;

            foreach (SpParam param in spParams)
            {
                if (true == param.ParamDirectionOut)
                {
                    SqlParameter sp = new SqlParameter(param.Name, param.Value);
                    sp.Size = 10;
                    sp.Direction = ParameterDirection.Output;
                    command.Parameters.Add(sp);

                    //command.Parameters.AddWithValue(param.Name, param.Value).Direction = ParameterDirection.Output;
                }
                else
                    command.Parameters.AddWithValue(param.Name, param.Value);
            }
        }



        #endregion

        #region Methods

        /// <summary>
        /// Returns a new SqlConnection.
        /// </summary>
        /// <returns>SqlConnection object</returns>
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DBHelper.DefaultConnectionString;
            return conn;
        }

        #endregion




    
      
    }
}
