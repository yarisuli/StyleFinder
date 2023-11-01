using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;


namespace App_Ropa___Intento_1
{
    public static class DB
    {
#pragma warning disable CS0618 // 'ConfigurationSettings.AppSettings' está obsoleto: 'This method is obsolete, it has been replaced by System.Configuration!System.Configuration.ConfigurationManager.AppSettings'
        private static readonly string connectionString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectionString"];
#pragma warning restore CS0618 // 'ConfigurationSettings.AppSettings' está obsoleto: 'This method is obsolete, it has been replaced by System.Configuration!System.Configuration.ConfigurationManager.AppSettings'
        private static readonly DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");

        /// <summary>
        /// Use when returning data from multiple rows
        /// </summary>
        /// <param name="sql">query</param>
        /// <param name="parameters">declared parameters</param>
        /// <returns>datatable of db rows</returns>
        public static DataTable GetDataTable(string sql, OleDbParameter[] parameters)
        {
            try
            {
                using (DbConnection connection = factory.CreateConnection())
                {
                    connection.ConnectionString = connectionString;

                    using (DbCommand command = factory.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = sql;

                        if (parameters != null)
                        {
                            foreach (var parameter in parameters)
                            {
                                if (parameter != null)
                                    command.Parameters.Add(parameter);
                            }
                        }
                        using (DbDataAdapter adapter = factory.CreateDataAdapter())
                        {
                            adapter.SelectCommand = command;

                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            return dt;
                        }
                    }
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// Use when returning data from multiple rows
        /// </summary>
        /// <param name="sql">query</param>
        /// <param name="parameters">declared parameters</param>
        /// <returns>value of autonumeric_id inserted</returns>
        public static Int32 Insert(string sql, OleDbParameter[] parameters)
        {
            try
            {
                using (DbConnection connection = factory.CreateConnection())
                {
                    connection.ConnectionString = connectionString;

                    using (DbCommand command = factory.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = sql;

                        if (parameters != null)
                        {
                            foreach (var parameter in parameters)
                            {
                                if (parameter != null)
                                    command.Parameters.Add(parameter);
                            }
                        }
                        using (DbDataAdapter adapter = factory.CreateDataAdapter())
                        {
                            command.Connection.Open();
                            adapter.InsertCommand = command;
                            adapter.InsertCommand.ExecuteNonQuery();

                            command.CommandText = "SELECT @@IDENTITY";
                            adapter.SelectCommand = command;

                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            try
                            {
                                return dt.Rows[0].Field<Int32>(0);
                            } catch
                            {
                                return -1;
                            }
                            finally
                            {
                                command.Connection.Close();
                            }
                            
                        }
                    }
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Run an update command
        /// </summary>
        /// <param name="sql">update</param>
        /// <param name="parameters">declared parameters</param>

        public static void Update(string sql, OleDbParameter[] parameters)
        {
            try
            {
                using (DbConnection connection = factory.CreateConnection())
                {
                    connection.ConnectionString = connectionString;

                    using (DbCommand command = factory.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = sql;

                        if (parameters != null)
                        {
                            foreach (var parameter in parameters)
                            {
                                if (parameter != null)
                                    command.Parameters.Add(parameter);
                            }
                        }
                        using (DbDataAdapter adapter = factory.CreateDataAdapter())
                        {

                           command.Connection.Open();
                            adapter.UpdateCommand = command;
                            adapter.UpdateCommand.ExecuteNonQuery();
                              command.Connection.Close();
                          

                        }
                    }
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Use to execute non query sql
        /// </summary>
        /// <param name="sql">non query</param>
        /// <param name="parameters">declared parameters</param>
        /// <returns>rows affected</returns>
        public static int ExecuteNonQuery(string sql, OleDbParameter[] parameters)
        {
            try
            {
                using (DbConnection connection = factory.CreateConnection())
                {
                    connection.ConnectionString = connectionString;

                    using (DbCommand command = factory.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = sql;

                        if (parameters != null)
                        {
                            foreach (var parameter in parameters)
                            {
                                if (parameter != null)
                                    command.Parameters.Add(parameter);
                            }
                        }

                        command.Connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        command.Connection.Close();

                        return rowsAffected;
                    }
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}


