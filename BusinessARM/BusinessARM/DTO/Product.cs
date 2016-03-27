using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessARM.DTO
{
    public class Product
    {
        private Units UnitId;

        public Guid id { set; get; }
        public String description { set; get; }
        public Guid productGroupID { set; get; }
        public Units Unit { set; get; }
        public Decimal weight { set; get; }
        public Decimal money { set; get; }
        public int quantity { set; get; }



        public override string ToString()
        {
            return description;
        } 
        //public
    }
    
}
