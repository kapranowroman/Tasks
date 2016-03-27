using BusinessARM.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace BusinessARM.DAO
{
   public class productDAO
    {
       public List<Product> getList() 
       {

           NpgsqlConnection connection = new NpgsqlConnection("Server = localhost; Port = 5432; Database = Business; UserId= business; Password = business;");
           NpgsqlCommand cmd = new NpgsqlCommand(
               @"SELECT productid
, description
, productgroupid
, unitid
, weight
, cost
, quantity
FROM products;"
, connection);
           connection.Open();
           List<Product> result = new List<Product>();
           var reader = cmd.ExecuteReader();
           while (reader.Read())
           {
               Product temp = new Product();
               temp.id = reader.GetGuid(0);
               temp.description = reader.GetString(1);
               temp.productGroupID = reader.GetGuid(2);
               temp.Unit = Units.FromName(reader.GetString(3));
               
               if (!reader.IsDBNull(4)) 
               {
                   temp.weight =(Decimal) reader.GetFloat(4);
               }
               
               temp.money = reader.GetDecimal(5);
               temp.quantity = reader.GetInt32(6);
               result.Add(temp);
          }


           
           return result;

       }

       public productDAO getById(Guid id)
       {
           throw new NotImplementedException();
       }

       public bool add(Product product)
       {
           throw new NotImplementedException();
       }

       public bool delete(Product product)
       {
           throw new NotImplementedException();
       }

       public bool update(Product product)
       {
           throw new NotImplementedException();
       }

    }
}
