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
       private NpgsqlConnection getConnection()
       {
          return new NpgsqlConnection("Server = localhost; Port = 5432; Database = Business; UserId= business; Password = business;");
       }

       private static String SELECT_CMD = @"SELECT productid
, description
, productgroupid
, unitid
, weight
, cost
, quantity
FROM products;";
       private static String INSERT_CMD =
@"INSERT INTO products (productid, description, productgroupid, unitid, weight, cost, quantity)
VALUES (:id, :desc, :groupid, :unitid, :weight, :cost, :quantity);";

       private static String UPDATE_CMD =
           @"UPDATE products SET 
description = :desc,
productgroupid = :groupid,
unitid = :unitid,
weight = :weight,
cost = :cost,
quantity = :quantity 
WHERE productid = :id;";
       private static String DELETE_CMD =
           @"DELETE FROM products WHERE productid= :id;";

       public List<Product> getList()
       {
           using (NpgsqlConnection connection = getConnection())
           {
               using (NpgsqlCommand cmd = new NpgsqlCommand(SELECT_CMD, connection))
               {
                   connection.Open();
                   List<Product> result = new List<Product>();
                   using (var reader = cmd.ExecuteReader())
                   {
                       while (reader.Read())
                       {
                           Product temp = new Product();
                           temp.id = reader.GetGuid(0);
                           temp.description = reader.GetString(1);
                           temp.productGroupID = reader.GetGuid(2);
                           temp.Unit = Units.FromName(reader.GetString(3));

                           if (!reader.IsDBNull(4))
                           {
                               temp.weight = (Decimal)reader.GetFloat(4);
                           }

                           temp.money = reader.GetDecimal(5);
                           temp.quantity = reader.GetInt32(6);
                           result.Add(temp);
                       }
                   }

                   return result;
               }
           }
       }

       public productDAO getById(Guid id)
       {
           throw new NotImplementedException();
       }

       public bool add(Product product)
       {
           using (NpgsqlConnection connection = getConnection())
           {
               connection.Open();
               using (NpgsqlCommand cmd = new NpgsqlCommand(INSERT_CMD, connection))
               {
                   var p = cmd.Parameters.Add(new NpgsqlParameter(":id", NpgsqlDbType.Uuid));
                   p.Value = product.id;
                   p = cmd.Parameters.Add(new NpgsqlParameter(":desc", NpgsqlDbType.Text));
                   p.Value = product.description;
                   p = cmd.Parameters.Add(new NpgsqlParameter(":groupid", NpgsqlDbType.Uuid));
                   p.Value = product.productGroupID;
                   p = cmd.Parameters.Add(new NpgsqlParameter(":unitid", NpgsqlDbType.Text));
                   p.Value = product.Unit.getDBName();
                   p = cmd.Parameters.Add(new NpgsqlParameter(":weight", NpgsqlDbType.Real));
                   p.Value = product.weight;
                   p = cmd.Parameters.Add(new NpgsqlParameter(":cost", NpgsqlDbType.Money));
                   p.Value = product.money;
                   p = cmd.Parameters.Add(new NpgsqlParameter(":quantity", NpgsqlDbType.Integer));
                   p.Value = product.quantity;

                   return cmd.ExecuteNonQuery() == 1;
               }
           }

       }

       public bool delete(Product product)
       {
           using (NpgsqlConnection connection = getConnection())
           {
               connection.Open();
               using (NpgsqlCommand cmd = new NpgsqlCommand(DELETE_CMD, connection))
               {
                   var p = cmd.Parameters.Add(new NpgsqlParameter(":id", NpgsqlDbType.Uuid));
                   p.Value = product.id;
                   return cmd.ExecuteNonQuery() == 1;
               }
           }
       }

       public bool update(Product product)
       {
           using (NpgsqlConnection connection = getConnection())
           {
               connection.Open();
               using (NpgsqlCommand cmd = new NpgsqlCommand(UPDATE_CMD, connection))
               {
                   var p = cmd.Parameters.Add(new NpgsqlParameter(":id", NpgsqlDbType.Uuid));
                   p.Value = product.id;
                   p = cmd.Parameters.Add(new NpgsqlParameter(":desc", NpgsqlDbType.Text));
                   p.Value = product.description;
                   p = cmd.Parameters.Add(new NpgsqlParameter(":groupid", NpgsqlDbType.Uuid));
                   p.Value = product.productGroupID;
                   p = cmd.Parameters.Add(new NpgsqlParameter(":unitid", NpgsqlDbType.Text));
                   p.Value = product.Unit.getDBName();
                   p = cmd.Parameters.Add(new NpgsqlParameter(":weight", NpgsqlDbType.Real));
                   p.Value = product.weight;
                   p = cmd.Parameters.Add(new NpgsqlParameter(":cost", NpgsqlDbType.Money));
                   p.Value = product.money;
                   p = cmd.Parameters.Add(new NpgsqlParameter(":quantity", NpgsqlDbType.Integer));
                   p.Value = product.quantity;

                   return cmd.ExecuteNonQuery() == 1;
               }
           }
       }


    }
}
