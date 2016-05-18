using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessARM.DTO
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String FatherName { get; set; }
        public String Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Marriage { get; set; }
        public String PostalIndex { get; set; }
        public String Position { get; set; }
        public String HireType { get; set; }
        public String Notes { get; set; }

        public override string ToString()
        {
            return LastName+"  "+FirstName;
        } 
    }
}
