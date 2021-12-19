using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityApp.DAL
{
    class SavedCityRepository : SqLiteBaseRepository
    {
        public SavedCityRepository()
        {
            if (!DatabaseExists())
            {
                CreateDatabase();
            }
        }

        public int InsertSavedCity(SavedCity savedCity)
        {
            string sql = "INSERT INTO City (City, Info) Values (@City, @Info);";

            using (var connection = DbConnectionFactory())
            {
                connection.Open();
                return connection.Execute(sql, savedCity);
            }
        }

        public int DeleteSavedCity(string city)
        {
            string sql = "DELETE FROM City WHERE City = @City;";

            using (var connection = DbConnectionFactory())
            {
                connection.Open();
                return connection.Execute(sql, new { City = city });
            }
        }

        public IEnumerable<SavedCity> GetSavedCities()
        {
            string sql = "SELECT * FROM City;";

            using (var connection = DbConnectionFactory())
            {
                return connection.Query<SavedCity>(sql);
            }
        }
    }
}
