using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL.Models
{
	public interface IDbRequestExecutor
	{
		Task<object> ExecuteScalarAsync(SqlCommand sqlCommand, SqlConnection dbConnection);

		Task<int> ExecuteNonQueryAsync(SqlCommand sqlCommand, SqlConnection dbConnection);
	}
	
	public class DbRequestExecutor: IDbRequestExecutor
	{
		public async Task<object> ExecuteScalarAsync(SqlCommand sqlCommand, SqlConnection dbConnection)
		{
			object result = null;
			
			try
			{
				dbConnection.Open();

				result = await sqlCommand.ExecuteScalarAsync();
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

			return result;
		}

		public async Task<int> ExecuteNonQueryAsync(SqlCommand sqlCommand, SqlConnection dbConnection)
		{
			int result = 0;
			try
			{
				dbConnection.Open();
				result = await sqlCommand.ExecuteNonQueryAsync();
			}
			catch(SqlException e)
			{
				Console.WriteLine("Error Generated. Details: " + e.ToString());
			}
			finally
			{
				dbConnection.Close();
			}

			return result;
		}
	}
}