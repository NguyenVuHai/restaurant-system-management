using System;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Windows.Forms;

/// <summary>
/// Summary description for DataAccessCode
/// </summary>
public static class DataAccessCode
{
    static DataAccessCode()
    {
    }
    //public static DbCommand CreateCommand()
    //{
    //    string providerName = RestaurantConfiguration.DbProviderName;
    //    string connectionString = RestaurantConfiguration.DbConnectionString;
    //    DbProviderFactory factory = DbProviderFactories.GetFactory(providerName);
    //    DbConnection connection = factory.CreateConnection();
    //    connection.ConnectionString = connectionString;
    //    RestaurantConfiguration.command = connection.CreateCommand();
    //    RestaurantConfiguration.command.CommandType = CommandType.StoredProcedure;
    //    return RestaurantConfiguration.command;
    //}

    public static DbCommand CreateCommand()
    {
        string providerName = RestaurantConfiguration.DbProviderName;
        string connectionString = RestaurantConfiguration.DbConnectionString;
        DbProviderFactory factory = DbProviderFactories.GetFactory(providerName);
        DbConnection connection = factory.CreateConnection();
        connection.ConnectionString = connectionString;
        DbCommand command = connection.CreateCommand();
        command.CommandType = CommandType.StoredProcedure;
        return command;
    }

    public static DataTable ExecuteSelectCommand(DbCommand command)
    {
        DataTable table = null;
        try
        {
            command.Connection.Open();
            DbDataReader reader = command.ExecuteReader();
            table = new DataTable();
            table.Load(reader);
            reader.Close();
        }
        catch (Exception ex)
        {
            //throw ex;
        }
        finally
        {
            command.Connection.Close();
        }
        return table;
    }
    public static DataTable ExecuteSecondSelectCommand(DbCommand command)
    {
        DataTable table = null;
        try
        {
            command.Connection.Open();
            DbDataReader reader = command.ExecuteReader();
            if (reader.HasRows) 
            {
                reader.NextResult();
            }
            table = new DataTable();
            table.Load(reader);
            reader.Close();
        }
        catch (Exception ex)
        {
            //throw ex;
        }
        finally
        {
            command.Connection.Close();
        }
        return table;
    }


    public static int ExecuteNonQuery(DbCommand command)
    {
        // The number of affected rows 
        int affectedRows = -1;
        // Execute the command making sure the connection gets closed in the
        try
        {
            // Open the connection of the command
            command.Connection.Open();
            // Execute the command and get the number of affected rows
            affectedRows = command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
        }
        finally
        {
            // Close the connection
            command.Connection.Close();
        }
        // return the number of affected rows
        return affectedRows;
    }

    // execute a select command and return a single result as a string
    public static string ExecuteScalar(DbCommand command)
    {
        // The value to be returned 
        string value = "";
        // Execute the command making sure the connection gets closed in the end
        try
        {
            // Open the connection of the command
            command.Connection.Open();
            // Execute the command and get the number of affected rows
            value = command.ExecuteScalar().ToString();
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            // Close the connection
            command.Connection.Close();
        }
        // return the result
        return value;
    }

    public static bool ExecuteQuery(string sql, DbCommand command)
    {
        int numRecordsEffect = 0;
        try
        {
            command.Connection.Open();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;              //Sau do xa gan cai sql vo chao CommandText la xong.



            numRecordsEffect = command.ExecuteNonQuery();
            //if (conn.State == ConnectionState.Open)
            //    conn.Close();
        }
        catch (Exception ex)
        {
            // throw;
            MessageBox.Show("Lỗi: " + ex.Message);
        }
        finally
        {
            command.Connection.Close();
        }
        if (numRecordsEffect > 0)
            return true;
        return false;
    }
}

//DbCommand command = DataAccessCode.CreateCommand();
//            command.CommandText = "SP_GETTABLES";
//            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
//            dataGridView1.DataSource = dt;