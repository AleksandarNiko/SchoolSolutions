using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop
{
    public class SparePart
    {
        private string code;
        private string name;
        private decimal buyPrice;
        private decimal clientPrice;

        public SparePart(string code, string name, Category category, ManufacturerCompany company)
        {
            Code = code;
            Name = name;
            Category = category;
            Company = company;
            Cars = new List<Car>();
        }

        public string Code { get => code; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value cannot be null");
                }
                code = value;
            }
        }

        public string Name { get => name; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value cannot be null");
                }
                name = value;
            }
        }

        public  Category  Category { get; set; }

        public decimal BuyPrice { get => buyPrice; set 
            {
                if (value < 0) 
                {
                    throw new ArgumentOutOfRangeException("value cannot be null"); 
                }
                buyPrice = value;
            } 
        }

        public  List<Car> Cars { get; set; }

        public ManufacturerCompany Company { get; set; }

        public decimal ClientPrice { get => clientPrice; set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value cannot be null");
                }
                clientPrice = value+(0.15M*BuyPrice);
            }
        }
    }
}

public enum Category
{
    Ходова_част,
    гуми_и_джанти,
    двигател,
    аксесоари
}
