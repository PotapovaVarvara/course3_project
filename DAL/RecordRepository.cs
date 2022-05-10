

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL.Models
{
    public interface IRecordRepository {
        Task<UserRecord> GetByIdAsync(Guid userId);

        Task<List<UserRecord>> GetAllByUserAsync(Guid userId);

        Task<int> AddRecordAsync(UserRecord model);
    }

    public class RecordRepository : RepositoryBase, IRecordRepository
    {
		private readonly IDbRequestExecutor _dbRequestExecutor;

		public RecordRepository(
			IDbRequestExecutor dbRequestExecutor,
			IDbInfrastructurer dbInfrastructurer)
			: base(dbRequestExecutor, dbInfrastructurer)
		{
			_dbRequestExecutor = dbRequestExecutor;
		}

        public async Task<int> AddRecordAsync(UserRecord model)
        {
            await EnsureTableExists();

            var dbConnection = DbManager.GetConnectionWithDb();
            string addUserExpression = $"INSERT INTO [{TableName}] (Id,Date,BodyPart,Note,UserId,FileName)"
                + "VALUES (@Id,@Date,@BodyPart,@Note,@UserId,@FileName)";
           
            var addUserCommand = new SqlCommand(addUserExpression, dbConnection);

            addUserCommand.Parameters.Add(new SqlParameter("@Id", model.Id));
            addUserCommand.Parameters.Add(new SqlParameter("@Date", model.RecordDate));
            addUserCommand.Parameters.Add(new SqlParameter("@BodyPart", model.BodyPart));
            addUserCommand.Parameters.Add(new SqlParameter("@Note", model.Note));
            addUserCommand.Parameters.Add(new SqlParameter("@FileName", model.FileName));
            addUserCommand.Parameters.Add(new SqlParameter("@UserId", model.UserId));

            return await _dbRequestExecutor.ExecuteNonQueryAsync(addUserCommand, dbConnection);
        }

        public async Task<List<UserRecord>> GetAllByUserAsync(Guid userId)
        {
            await EnsureTableExists();

            var resultList = new List<UserRecord>();

            var sqlExpression = $"SELECT Id, BodyPart, Date, FileName, Note from [{TableName}] where UserId = @id";

            await using var connection = DbManager.GetConnectionWithDb();
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.Parameters.Add(new SqlParameter("@id", userId));

            var reader = await command.ExecuteReaderAsync();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    resultList.Add(new UserRecord
                    {
                        Id = Guid.Parse(reader.GetValue(0).ToString() ?? string.Empty),
                        BodyPart = reader.GetValue(1).ToString(),
                        RecordDate= DateTime.Parse(reader.GetValue(2).ToString() ?? string.Empty),
                        FileName = reader.GetValue(3).ToString(),
                        Note = reader.GetValue(4).ToString()
                    });
                }
            }

            await reader.CloseAsync();

            return resultList;
        }

        public async Task<UserRecord> GetByIdAsync(Guid userId)
        {
            await EnsureTableExists();

            UserRecord model = null;

            var sqlExpression = $"Select Id, BodyPart, Date, FileName, Note from[{TableName}] where Id = @id";

            await using var connection = DbManager.GetConnectionWithDb();

            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.Parameters.Add(new SqlParameter("@id", userId));

            var reader = await command.ExecuteReaderAsync();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    model = new UserRecord
                    {
                        Id = Guid.Parse(reader.GetValue(0).ToString() ?? string.Empty),
                        BodyPart = reader.GetValue(1).ToString(),
                        RecordDate = DateTime.Parse(reader.GetValue(2).ToString() ?? string.Empty),
                        FileName = reader.GetValue(3).ToString(),
                        Note = reader.GetValue(4).ToString()
                    };
                }
            }

            await reader.CloseAsync();

            return model;
        }

        protected override string TableName => "Record";

        protected override string CreateTableQuery =>
            "CREATE TABLE [dbo].[Record](" +
            "[Id][nvarchar](50) NOT NULL PRIMARY KEY CLUSTERED ," +
            "[Date] [date] NOT NULL," +
            "[BodyPart] [nvarchar]	(max) NULL," +
            "[Note] [nvarchar] (max) NULL," +
            "[UserId] [nvarchar] (50) NOT NULL," +
            " [FileName] [nvarchar] (max) NOT NULL," +
            "CONSTRAINT fk_user_record FOREIGN KEY(UserId) REFERENCES[dbo].[Users] (Id))";


    }
}
