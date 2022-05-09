
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL.Models
{
	public interface IUserRepository
	{
		Task<int> AddUserAsync(User user);
		
		Task<List<User>> GetAllUsersAsync();

		Task<User> GetUsersByIdAsync(Guid userId);
	}
	
	public class UserRepository: RepositoryBase, IUserRepository
	{
		
		private readonly IDbRequestExecutor _dbRequestExecutor;
		
		public UserRepository(
			IDbRequestExecutor dbRequestExecutor,
			IDbInfrastructurer dbInfrastructurer)
			: base(dbRequestExecutor, dbInfrastructurer)
		{
			_dbRequestExecutor = dbRequestExecutor;
		}

		public async Task<int> AddUserAsync(User user)
		{
			await EnsureTableExists();

			var dbConnection = DbManager.GetConnectionWithDb();
			string addUserExpression = "INSERT INTO [Users] (Id, Name, Sex, DOB, Complaints) VALUES (@id, @name, @sex, @dob, @complaints)";
			
			var addUserCommand = new SqlCommand(addUserExpression, dbConnection);

			addUserCommand.Parameters.Add(new SqlParameter("@tableName", TableName));
			addUserCommand.Parameters.Add(new SqlParameter("@id", user.Id));
			addUserCommand.Parameters.Add(new SqlParameter("@name", user.Name));
			addUserCommand.Parameters.Add(new SqlParameter("@sex", user.Sex));
			addUserCommand.Parameters.Add(new SqlParameter("@dob", user.DOB));
			addUserCommand.Parameters.Add(new SqlParameter("@complaints", user.Complaints));

			
			return await _dbRequestExecutor.ExecuteNonQueryAsync(addUserCommand, dbConnection);
		}

		public async Task<List<User>> GetAllUsersAsync()
		{
			await EnsureTableExists();
			
			var usersList = new List<User>();
			
			var sqlExpression = "SELECT Id, Name, DOB, Sex, Complaints from [Users]";

			await using var connection = DbManager.GetConnectionWithDb();
			connection.Open();
			SqlCommand command = new SqlCommand(sqlExpression, connection);
			var reader = await command.ExecuteReaderAsync();
 
			if(reader.HasRows)
			{
				while (reader.Read())
				{
					usersList.Add(new User
					{
						//reader.GetValue(2).ToString() == true? "male":"female",
						Id = Guid.Parse(reader.GetValue(0).ToString() ?? string.Empty),
						Name = reader.GetValue(1).ToString(),
						DOB = DateTime.Parse(reader.GetValue(2).ToString() ?? string.Empty),
						Sex = bool.Parse(reader.GetValue(3).ToString() ?? string.Empty),
						Complaints = reader.GetValue(4).ToString()
					});
				}
			}
         
			await reader.CloseAsync();

			return usersList;
		}

        public async Task<User> GetUsersByIdAsync(Guid userId)
        {
			await EnsureTableExists();

			User userModel = null;

			var sqlExpression = $"SELECT Id, Name, DOB, Sex, Complaints from [{TableName}] where id = @id";

			await using var connection = DbManager.GetConnectionWithDb();

			connection.Open();
			SqlCommand command = new SqlCommand(sqlExpression, connection);
			command.Parameters.Add(new SqlParameter("@id", userId));

			var reader = await command.ExecuteReaderAsync();

			if (reader.HasRows)
			{
				while (reader.Read())
				{
					userModel = new User
					{
						Id = Guid.Parse(reader.GetValue(0).ToString() ?? string.Empty),
						Name = reader.GetValue(1).ToString(),
						DOB = DateTime.Parse(reader.GetValue(2).ToString() ?? string.Empty),
						Sex = bool.Parse(reader.GetValue(3).ToString() ?? string.Empty),
						Complaints = reader.GetValue(4).ToString()
					};
				}
			}

			await reader.CloseAsync();

			return userModel;
		}

        protected override string TableName => "Users";

		protected override string CreateTableQuery =>
			"CREATE TABLE [Users] ( Id nvarchar(50) NOT NULL PRIMARY KEY CLUSTERED, Name nvarchar(50) NULL, DOB date NULL, Sex bit NULL, Complaints nvarchar(max) NULL )";
	}
}