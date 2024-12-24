namespace _02.Kindergarten
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Избери:");
            Console.WriteLine("1 -> Запиши дете");
            Console.WriteLine("2 -> Търси дете по име");
            Console.WriteLine("3 -> Извеждане на имената на децата в груп2а подадена от клавиатурата");
            Console.WriteLine("4 -> Извеждане на всички деца от градината");

            var kids = new List<Kid>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("Въведи име:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Въведи презиме:");
                    string middleName = Console.ReadLine();
                    Console.WriteLine("Въведи фамилия:");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Въведи дата на раждане:");
                    string birthDate = Console.ReadLine();
                    Console.WriteLine("Въведи възраст:");
                    byte age = byte.Parse(Console.ReadLine());
                    Console.WriteLine("Въведи група:");
                    TypeGroup typeGroup = (TypeGroup)Enum.Parse(typeof(TypeGroup), Console.ReadLine());
                    kids.Add(new Kid(firstName, middleName, lastName, birthDate, age, typeGroup));
                    Console.WriteLine("Успешно добавено дете!");
                }
                else if (input == "2")
                {
                    Console.WriteLine("Въведи име:");
                    string name = Console.ReadLine();
                    var kid = kids.FirstOrDefault(k => k.FirstName == name);
                    if (kid != null)
                    {
                        Console.WriteLine($"Име: {kid.FirstName}");
                        Console.WriteLine($"Презиме: {kid.MiddleName}");
                        Console.WriteLine($"Фамилия: {kid.LastName}");
                        Console.WriteLine($"Дата на раждане: {kid.BirthDate}");
                        Console.WriteLine($"Възраст: {kid.Age}");
                        Console.WriteLine($"Група: {kid.TypeGroup}");
                    }
                    else
                    {
                        Console.WriteLine("Не е намерено дете с това име");
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("Въведи група:");
                    TypeGroup typeGroup = (TypeGroup)Enum.Parse(typeof(TypeGroup), Console.ReadLine());
                    var kidsInGroup = kids.Where(k => k.TypeGroup == typeGroup);
                    foreach (var kid in kidsInGroup)
                    {
                        Console.WriteLine(kid.FirstName);
                    }
                }
                else if (input == "4")
                {
                    foreach (var kid in kids)
                    {
                        Console.WriteLine($"{kid.FirstName} {kid.MiddleName} {kid.LastName}");
                    }
                }
                else
                {
                    Console.WriteLine("Грешна команда! Край.");
                    break;
                }
            }
        }
    }
}
