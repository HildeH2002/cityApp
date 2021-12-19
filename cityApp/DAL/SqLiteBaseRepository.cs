using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityApp.DAL
{
    class SqLiteBaseRepository
    {
        public SqLiteBaseRepository()
        {
        }

        public static SqliteConnection DbConnectionFactory()
        {
            return new SqliteConnection(@"DataSource=CityDB.sqlite");
        }

        protected static bool DatabaseExists()
        {
            return File.Exists(@"CityDB.sqlite");
        }

        protected static void CreateDatabase()
        {
            using (var connection = DbConnectionFactory())
            {
                connection.Open();
                connection.Execute(
                    @"CREATE TABLE City
                    (Id                 INTEGER PRIMARY KEY AUTOINCREMENT,
                    City                VARCHAR(40) UNIQUE,
                    Info                VARCHAR(100)
                    )");
            }
        }
    }
}
