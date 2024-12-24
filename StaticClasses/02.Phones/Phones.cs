using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phones
{
    public static class Phones
    {
        private static List<Phone> phones = new List<Phone>();

        public static void Add(DateTime date, string model, string maker, decimal price)
        {
            phones.Add(new Phone(model, maker, price, date));
            Console.WriteLine("Успешно добавяне!");
        }

        public static void FindPhoneByModel(string model) 
        {
            var currPhones = new List<Phone>();

            foreach (var phone in phones) 
            {
                if (phone.Model == model) 
                {
                    currPhones.Add(phone);
                }
            }

            foreach (var phone in currPhones)
            {
                Console.WriteLine($"Model: {phone.Model}; CreatedOn: {phone.CreatedOn.ToString()}; Price: {phone.Price:F2};");
            }
        }

        public static void FindPhoneByPrice(decimal startPrice, decimal endPrice)
        {
            var currPhones = new List<Phone>();

            foreach (var phone in phones)
            {
                if (phone.Price >= startPrice && phone.Price<=endPrice)
                { 
                    currPhones.Add(phone);
                }
            }

            foreach (var phone in currPhones)
            {
                Console.WriteLine($"Model: {phone.Model}; CreatedOn: {phone.CreatedOn.ToString()}; Price: {phone.Price:f2}");
            }
        }

        public static void FindPhoneByYear(string year) 
        {
            var currPhones = new List<Phone>();

            foreach (var phone in phones)
            {
                if (phone.CreatedOn.ToString() == year)
                {
                    currPhones.Add(phone);
                }
            }

            Console.WriteLine($"Year: {year}");
            foreach (var phone in currPhones)
            {
                Console.WriteLine($"Model: {phone.Model}; CreatedOn: {phone.CreatedOn.ToString()}; Price: {phone.Price:F2};");
            }
        }

        public static void FindPhoneByYearGap(DateTime startYear, DateTime endYear)
        {
            var currPhones = new List<Phone>();

            foreach (var phone in phones)
            {
                if (phone.CreatedOn >= startYear && phone.CreatedOn <= endYear)
                {
                    currPhones.Add(phone);
                }
            }

            
            foreach (var phone in currPhones)
            {
                Console.WriteLine($"Model: {phone.Model}; Price: {phone.Price:f2}");
            }
        }
    }
}
