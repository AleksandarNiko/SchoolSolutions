
using _02.Phones;
using static _02.Phones.Phones;

while (true)
{
    Console.Clear();
    Console.WriteLine("Меню:");
    Console.WriteLine("1. Въведи нови модели телефони");
    Console.WriteLine("2. Търсене по модел");
    Console.WriteLine("3. Търсене по цена");
    Console.WriteLine("4. Търсене по година");
    Console.WriteLine("5. Търсене по диапазон от години");
    Console.WriteLine("6. Изход");
    Console.Write("Изберете опция: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Въведи информацията във формат: година на производство, модел, производител, цена");
            string[] lineToken = Console.ReadLine().Split(",");

            DateTime date=DateTime.Parse(lineToken[0]);
            string model = lineToken[1];
            string maker=lineToken[2];
            decimal price=decimal.Parse(lineToken[3]);

            Add(date,model,maker,price);

            break;
        case "2":
            Console.WriteLine("Въведи информацията във формат: модел");
            string currModel=Console.ReadLine();
            FindPhoneByModel(currModel);
            break;
        case "3":
            Console.WriteLine("Въведи информацията във формат: начлна цена, крайна цена");
            decimal[] prices=Console.ReadLine().Split(",").Select(decimal.Parse).ToArray();
            decimal startPrice = prices[0];
            decimal endPrice = prices[1];
            FindPhoneByPrice(startPrice,endPrice);
            break;
        case "4":
            Console.WriteLine("Въведи информацията във формат: година");
            string year=Console.ReadLine();
            FindPhoneByYear(year);
            break;
        case "5":
            Console.WriteLine("Въведи информацията във формат: начлна година, крайна година");
            string[] lineToken1 = Console.ReadLine().Split(",");
            DateTime startYear=DateTime.Parse(lineToken1[0]);
            DateTime endYear=DateTime.Parse(lineToken1[1]); 
            FindPhoneByYearGap(startYear,endYear);
            break;
        case "6 ":
            return;
        default:
            Console.WriteLine("Невалиден избор, моля опитайте отново.");
            break;
    }
    Console.WriteLine("Натиснете клавиш за продължаване...");
}
