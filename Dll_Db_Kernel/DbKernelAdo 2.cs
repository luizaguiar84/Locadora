using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Dll_Db_Kernel
{
	public class DbKernelAdo
	{

		string connectionString = ConfigurationManager.ConnectionStrings["BdLocadora"].ConnectionString;

		public DataTable Select(string query)
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{

				SqlCommand command = new SqlCommand(query, con);
				DataTable dt = new DataTable();
				try
				{
					SqlDataAdapter da = new SqlDataAdapter(command);
					da.Fill(dt);
				}
				catch (Exception ex)
				{
					string error = ex.ToString();
				}
				return dt;
			}
		}
	}
}
