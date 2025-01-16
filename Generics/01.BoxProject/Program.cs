namespace _01.BoxProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Box_All<string> box = new Box_All<string>();

            string choice = "";
            while (choice != "exit")
            {
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine("1 - Add a treasure");
                Console.WriteLine("2 - Add a candy");
                Console.WriteLine("3 - Display the content of the box");
                Console.WriteLine("4 - Display the number of elements in the box");
                Console.WriteLine("D - Remove an element");
                Console.WriteLine("Exit - Exit the program");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter a treasure: ");
                        string treasure = Console.ReadLine();
                        box.Add_box(treasure);
                        break;
                    case "2":
                        Console.WriteLine("Enter a candy: ");
                        string candy = Console.ReadLine();
                        box.Add_box(candy);
                        break;
                    case "3":
                        Console.WriteLine("The content of the box is: ");
                        box.Display();
                        break;
                    case "4":
                        Console.WriteLine("The number of elements in the box is: ");
                        Console.WriteLine(box.Count);
                        break;
                    case "D":
                        Console.WriteLine("The last element was removed: ");
                        Console.WriteLine(box.Remove_box());
                        break;
                    case "Exit":
                        choice = "exit";
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
