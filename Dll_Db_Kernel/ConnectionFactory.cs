using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DbKernel
{
	public class ConnectionFactory
	{
		string connectionString = ConfigurationManager.ConnectionStrings["BdLocadora"].ConnectionString;

		public IDbConnection GetConnection()
		{
			IDbConnection conexao = new SqlConnection();
			conexao.ConnectionString = connectionString;
			conexao.Open();

			return conexao;
		}
	}
}
