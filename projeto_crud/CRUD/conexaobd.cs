using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
	public class conexaobd
	{
		private const string serv = "localhost";
		private const string uid = "root";
		private const string pwd = "";
		private const string db = "crud";

		static public string strConexao = $"server = {serv};uid = {uid}; password = {pwd} ;database = {db}";
	}
}
