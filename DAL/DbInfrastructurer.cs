using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Models
{
	public interface IDbInfrastructurer
	{
		void CreateDatabase();
	}
	
	public class DbInfrastructurer: IDbInfrastructurer
	{
		public void CreateDatabase()
		{
			var dbConnection = DbBuilder.GetConnection();
			
			var databaseName = DbBuilder.GetDbName();

			var createDb = $"CREATE DATABASE {databaseName } ON PRIMARY" +
			               $"(NAME = {databaseName}_Data, " +
			               $"FILENAME = 'C:\\nData\\{databaseName}.mdf', " +
			               "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%) "+
			               $"LOG ON (NAME = {databaseName}_Log, " +
			               $"FILENAME = 'C:\\nData\\{databaseName}Log.mdf', " +
			               "SIZE = 1MB, " +
			               "MAXSIZE = 5MB, " +
			               "FILEGROWTH = 10%)";

			var isDbExists = "select * from master.dbo.sysdatabases where name = @databaseNameParam";

			var createDbCommand = new SqlCommand(createDb, dbConnection);
			var isDbExistsCommand = new SqlCommand(isDbExists, dbConnection);
			isDbExistsCommand.Parameters.Add(new SqlParameter("@databaseNameParam", databaseName));
            
			try
			{
				dbConnection.Open();

				if(isDbExistsCommand.ExecuteScalar() == null)
					createDbCommand.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				if (dbConnection.State == ConnectionState.Open)
				{
					dbConnection.Close();
				}
			}
		}
	}
}