using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace mysql_bug
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var connection = new MySqlConnection("server=localhost;SslMode=none;user=root")) {
				connection.Open();

				var setup = @"

drop database if exists mysqlbug;
create database mysqlbug;
use mysqlbug;


CREATE PROCEDURE Test ()
BEGIN
	SELECT 1;
END
";


				var cmd = new MySqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = setup;
				cmd.ExecuteNonQuery();


				cmd.CommandText = "Mysqlbug.Test";
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.ExecuteNonQuery();
			}
		}
	}
}