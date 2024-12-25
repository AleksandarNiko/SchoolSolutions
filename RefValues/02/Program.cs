
List<string> text = new List<string>();

InputValues(text);

OutputValues(text);

StringsWithLength3(text);

static void InputValues(List<string> text)
{
    string input = "";

    while (input != "End")
    {
        input = Console.ReadLine();
        if(input == "End")
        {
            break;
        }
        text.Add(input);
    }
}

static void OutputValues(List<string> text)
{
    Console.WriteLine(string.Join(",",text));
}

static void StringsWithLength3(List<string> text)
{
    List<string> currStrings= new List<string>();   

    foreach (var item in text)
    {
        if (item.Length == 3)
        {
            currStrings.Add(item);
        }
    }

    if (currStrings.Count == 0)
    {
        Console.WriteLine("There is no strings with length=3!");
    }
    else
    {
        Console.WriteLine(string.Join(",", currStrings));
    }
}
