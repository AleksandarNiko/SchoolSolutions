
string input = Console.ReadLine();
Console.WriteLine(IsValid(input) ? "YES" : "NO");

static bool IsValid(string input)
{
    var stack = new Stack<char>();
    foreach (var c in input)
    {
        if (c == '(' || c == '{' || c == '[')
        {
            stack.Push(c);
        }
        else if (c == ')' || c == '}' || c == ']')
        {
            if (stack.Count == 0)
            {
                return false;
            }
            else
            {
                char top = stack.Pop();
                if (!IsMatching(top, c)) 
                {
                    return false; 
                }
            }
        }
    }
    return stack.Count == 0;
}

static bool IsMatching(char opening, char closing)
{
    return (opening == '(' && closing == ')') ||
           (opening == '{' && closing == '}') ||
           (opening == '[' && closing == ']');
}
