using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shop
{
    public static class Shop
    {
        private static List<Product> products = new List<Product>();

        public static void Add(string code,string name,decimal price,double quantity)
        {
            if (FindProductByCode(code)==null)
            {
                products.Add(new Product(name, code, price, quantity));
                Console.WriteLine($"Успешно добавихте продукт: {name}");
            }
            else 
            {
                Console.WriteLine($"Продуктът {name} вече съществува!");
            }
        }

        public static void ProductLoading(string code,double quantity)
        {
            Product product = FindProductByCode(code);

            if (product == null)
            {
                Console.WriteLine("Няма такъв продукт!");
            }

            product.Quantity += quantity;
        }


        public static void Sale(string code, double quantity) 
        {
            Product product = FindProductByCode(code);

            if (product == null)
            {
                Console.WriteLine("Няма такъв продукт!");
            }

            if (product.Quantity < quantity) 
            {
                Console.WriteLine("Няма достатъчно количество!");
            }

            product.Quantity -= quantity;
        }

        public static void AvailableProducts()
        {
            List<Product> currProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.Quantity > 0)
                {
                    currProducts.Add(product);
                }
            }

            Console.WriteLine("Налични продукти:");
            foreach (var product in currProducts)
            {
                Console.WriteLine(product.ToString());
            }
        }

        public static void UnavailableProducts()
        {
            List<Product> currProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.Quantity == 0)
                {
                    currProducts.Add(product);
                }
            }

            Console.WriteLine("Неналични продукти:");
            foreach (var product in currProducts)
            {
                Console.WriteLine(product.ToString());
            }

        }

        public static void AllProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }

        public static void AvailableProductsSum()
        {
            decimal sum = 0;

            List<Product> currProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.Quantity > 0)
                {
                    currProducts.Add(product);
                }
            }

            foreach (var product in currProducts)
            {
                sum += product.Price;
            }

            Console.WriteLine($"Стойността на всички налични продукти: {sum:f2}");
        }

        private static Product? FindProductByCode(string code)
        {
            Product product = null;

            foreach (Product p in products)
            {
                if (p.Code == code)
                {
                    product = p;
                    break;
                }
            }

            return product;
        }
    }
}
