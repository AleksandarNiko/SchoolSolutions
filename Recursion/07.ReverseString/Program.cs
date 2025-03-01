
string word = Console.ReadLine()!;
Reverse(word!);

static void  Reverse(string word)
{
    if(word.Length == 0)
    {
        return;
    }
    else
    {
        Console.Write(word[word.Length-1]);
        Reverse(word.Substring(0, word.Length-1));
    }
}
