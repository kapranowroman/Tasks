using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessARM.DTO
{
    public struct Units
    {
        private String description;
        private Units(String desc)
        {
            description = desc;
        }

        public static Units BOTTLE_033 { get{return new Units ("Бутылка 0.33");}}

        public static Units BOTTLE_05 { get{return new Units ("Бутылка 0.5");}}
        
        public static Units BOX {
            get{return new Units ("Коробка");}
        }
       
        public static Units CRATE
        {
            get{return new Units ("Ящик");}
        }
        
        public static Units GLASS_POT
        {
            get{return new Units ("Банка, стекло");}
        }
        
        public static Units PACK
        {
            get{return new Units ("Пачка");}
        }
        public static Units PACKING
        {
            get { return new Units("Упаковка"); }
        }
               
        public static Units TIN_POT
        {
        get{return new Units ("Банка, жесть");}
        }

        public static Units UNIT
        {
            get { return new Units("штука"); }
        }

        public static Units FromName(String name)
        {
            switch (name)
            {
                case "BOTTLE_033": return BOTTLE_033;
                case "BOTTLE_05": return BOTTLE_05;
                case "BOX": return BOX;
                case "CRATE": return CRATE;
                case "GLASS_POT": return GLASS_POT;
                case "PACK": return PACK;
                case "PACKING": return PACKING;
                case "TIN_POT": return TIN_POT;
                case "UNIT": return UNIT;
                default:
                    throw new ArgumentException("Unknown Unit type " + name);
            }
        }
        public override string ToString()
        {
            return description;
        }
    }
}
