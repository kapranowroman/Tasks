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
    public class EmployeeDAO
    {
        private NpgsqlConnection getConnection()
        {
            return new NpgsqlConnection("Server = localhost; Port = 5432; Database = Business; UserId= business; Password = business;");
        }
        private static String CHECK_CMD =
           @"SELECT count(e.employeeid)
FROM employees e
WHERE e.employeeid=:id
AND ( exists (SELECT 1 FROM positions p WHERE p.managerid=e.employeeid)
OR
exists (SELECT 1 FROM orders r WHERE r.employeeid=e.employeeid 
AND r.finished=true))";
        private static String UPDATE_CMD =
            @"UPDATE employees SET 
position = :position
WHERE employeeid = :id;";
        public List<Employee> getList()
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server = localhost; Port = 5432; Database = Business; UserId= business; Password = business;");
            NpgsqlCommand cmd = new NpgsqlCommand(
             @"SELECT employeeid
,lastname
,firstname
,fathername
,gender
,birthdate
,marriage
,postalindex
,position
,hiretype
,notes
FROM employees;"
             , connection);
            connection.Open();
            List<Employee> result = new List<Employee>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            { 
            Employee temp = new Employee();
            temp.EmployeeId = reader.GetGuid(0);
            temp.LastName = reader.GetString(1);
            temp.FirstName = reader.GetString(2);
            temp.FatherName = reader.GetString(3);
            temp.Gender = reader.GetString(4);
            temp.BirthDate = reader.GetDateTime(5);
            temp.Marriage = reader.GetBoolean(6);
            temp.PostalIndex = reader.GetString(7);
            temp.Position = reader.GetString(8);
            temp.HireType = reader.GetString(9);
            temp.Notes = reader.GetString(10);
            result.Add(temp);

            }
            return result;
        }
        
        public EmployeeDAO getById(Guid id)
        { 
            throw new NotImplementedException(); 
        }
        
        public bool add(Employees employee)
        {
            throw new NotImplementedException();
        }

        public bool delete(Employees employee)
        { 
        throw new NotImplementedException();
        }
        public bool dismissal(Employees employee)
        {
            using (NpgsqlConnection connection = getConnection())
            {
                connection.Open();
                using (NpgsqlTransaction tran = connection.BeginTransaction())
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(UPDATE_CMD, connection))
                    {
                        var p = cmd.Parameters.Add(new NpgsqlParameter(":id", NpgsqlDbType.Uuid));
                        p.Value = employee.EmployeeId;
                        

                        bool result = cmd.ExecuteNonQuery() == 1;
                        tran.Commit();
                        return result;
                    }
                }
            }
        }


    }
}
