

using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL.Models
{
    public interface IRecordRepository {
        //Task<int> GetAllByUserAsync(User user);
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
