using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessARM.DTO
{
   public class ProductGroup
    {
       public Guid Id { get; set; }
       public String Name { get; set; }
       public override string ToString()
       {
           return Name;
       }
    }
}
