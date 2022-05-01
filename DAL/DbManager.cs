using System.Data.SqlClient;

namespace DAL.Models
{
	public static class DbManager
	{
		public static SqlConnection GetConnection()
		{
			return new("Integrated security=true;Data Source=WS-VPOTAPOVA; database=master;");
		}
		
		public static string GetDbName()
		{
			return "DicomViewerDb";
		}
		
		public static SqlConnection GetConnectionWithDb()
		{
			return new($"Integrated security=true;Data Source=WS-VPOTAPOVA; database={GetDbName()};");
		}
	}
}