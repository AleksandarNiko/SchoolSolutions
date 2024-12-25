


using _03.Performer;

TaskA();

TaskB();

TaskC();

static void TaskA()
{
    //A)
    string firstName = "Vasil";
    string lastName = "Naidenov";
    string genre = "pop";
    byte albumsCount = 7;
    Performer performer = new Performer(firstName, lastName, genre, albumsCount);

    Console.WriteLine(performer.ToString());
}

static void TaskB()
{
    Performer performer2 = new Performer();


        performer2.FirstName = "Lili";
      performer2.LastName = "Ivanova"; 
        performer2.Genre = "Estrada";
     performer2.AlbumsCount = 2;
    
    Console.WriteLine(performer2.ToString());
}

static void TaskC()
{
    List<Performer> performers = new List<Performer>();

    string input = "";
    while (input != "Close")
    {
        input = Console.ReadLine();
        string[] lineToken = input.Split(",");

        string firsName = lineToken[0];
        string lasName = lineToken[1];
        string genr = lineToken[2];
        byte albumCount = byte.Parse(lineToken[3]);

        performers.Add(new Performer(firsName, lasName, genr, albumCount));

        if (input == "Close")
        {
            break;
        }
    }

    Console.WriteLine("Златни:");
    foreach (var item in performers)
    {
        if (item.IsGoldPerformer() == "златен")
        {
            Console.WriteLine(item.ToString());
        }
    }

    Console.WriteLine("Сребърни:");
    foreach (var item in performers)
    {
        if (item.IsGoldPerformer() == "сребърен")
        {
            Console.WriteLine(item.ToString());
        }
    }
    Console.WriteLine("Прохождащи:");
    foreach (var item in performers)
    {
        if (item.IsGoldPerformer() == "прохождащ")
        {
            Console.WriteLine(item.ToString());
        }
    }
}