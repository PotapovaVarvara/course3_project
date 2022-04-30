using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL.Models
{
	public abstract class RepositoryBase
	{
		protected abstract string TableName {get; }
		
		protected abstract string CreateTableQuery {get; }

		private readonly IDbRequestExecutor _dbRequestExecutor;

		private readonly IDbInfrastructurer _dbInfrastructurer;
		
		protected RepositoryBase(
			IDbRequestExecutor dbRequestExecutor,
			IDbInfrastructurer dbInfrastructurer)
		{
			_dbRequestExecutor = dbRequestExecutor;
			_dbInfrastructurer = dbInfrastructurer;
		}

		protected async Task EnsureTableExists()
		{
			if (!DatabaseExists())
			{
				_dbInfrastructurer.CreateDatabase();
			}

			if (await TableExistsAsync())
			{
				return;
			}
			
			var dbConnection = DbManager.GetConnectionWithDb();
			SqlCommand cmd = new SqlCommand(CreateTableQuery, dbConnection);
			cmd.Parameters.Add(new SqlParameter("@tableName", TableName));
			
			try
			{
				dbConnection.Open();
				cmd.ExecuteNonQuery();
				Console.WriteLine("Table Created Successfully");
			}
			catch(SqlException e)
			{
				Console.WriteLine("Error Generated. Details: " + e.ToString());
			}
			finally
			{
				dbConnection.Close();
			}
		}

		private async Task<bool> TableExistsAsync()
		{
			var dbConnection = DbManager.GetConnectionWithDb();
			
			var isTableExists = "SELECT * FROM DicomViewerDb.sys.tables WHERE name=@tableName";
			
			var isDbExistsCommand = new SqlCommand(isTableExists, dbConnection);

			isDbExistsCommand.Parameters.Add(new SqlParameter("@tableName", TableName));

			return (await _dbRequestExecutor.ExecuteScalarAsync(isDbExistsCommand, dbConnection)) != null;
		}
		
		private bool DatabaseExists()
		{
			string sqlCreateDBQuery;
			bool result = false;

			try
			{
				var tmpConn = DbManager.GetConnection();

				sqlCreateDBQuery = string.Format("SELECT database_id FROM sys.databases WHERE Name = '{0}'", DbManager.GetDbName());
				
				using (tmpConn)
				{
					using (SqlCommand sqlCmd = new SqlCommand(sqlCreateDBQuery, tmpConn))
					{
						tmpConn.Open();

						object resultObj = sqlCmd.ExecuteScalar();

						int databaseID = 0;    

						if (resultObj != null)
						{
							int.TryParse(resultObj.ToString(), out databaseID);
						}

						tmpConn.Close();

						result = (databaseID > 0);
					}
				}
			} 
			catch (Exception ex)
			{ 
				result = false;
			}

			return result;
		}
	}
}