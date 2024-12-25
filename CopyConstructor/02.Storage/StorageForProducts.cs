using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Storage
{
    public class StorageForProducts
    {
        public StorageForProducts() 
        {
            Products=new List<Product>();
        }

        public  List<Product> Products { get; set; }

        private bool YesOrNo(Product product)
        {
            return Products.Contains(product);
        }

        public void Add(Product product) 
        {
            if (!YesOrNo(product)) 
            {
                Products.Add(product);
            }
        }

        public void Delivery(Product product)
        {
            if (YesOrNo(product)==true)
            {
                product.Quantity += product.Quantity;
            }
            else
            {
                Console.WriteLine("Invalid product {0}!",product.Name);
            }
        }

        public void Sale(Product product) 
        {
            if (!YesOrNo(product))
            {
                Console.WriteLine("Invalid product {0}!", product.Name);
            }

            foreach (var item in Products) 
            {
                if (item.Name == product.Name)
                {
                    item.Quantity -= product.Quantity;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Storage capacity: {Products.Count}");

            foreach (var item in Products) 
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
