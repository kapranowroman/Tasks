using BusinessARM.DTO;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessARM.DAO
{
    class ProductGroupDAO
    {
        private static String SELECT_CMD =
@"SELECT
productgroupid,
name
FROM productgroups;";

        private NpgsqlConnection getConnection()
        {
            return new NpgsqlConnection("Server = localhost; Port = 5432; Database = Business; UserId= business; Password = business;");
        }
        public List<ProductGroup> getList()
        {
            using (NpgsqlConnection connection = getConnection())
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(SELECT_CMD, connection))
                {
                    
                    List<ProductGroup> result = new List<ProductGroup>();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProductGroup temp = new ProductGroup();
                            temp.Id = reader.GetGuid(0);
                            temp.Name = reader.GetString(1);
                            result.Add(temp);
                        }
                    }

                    return result;
                }
            }
        }
    }
}
