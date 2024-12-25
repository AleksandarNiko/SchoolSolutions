static void InsertValues(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
}
static void PrintArrayOnOneLine(int[] array)
{
    Console.WriteLine(string.Join("; ",array));
}
static void PrintEvenNumbersInNewArray(int[] array) 
{
    int[] newArray1=new int[array.Length];

    foreach (var item in array)
    {
        if (item % 2 == 0)
        {
            for (int i = 0; i < newArray1.Length; i++)
            {
                newArray1[i] = item;
            }
        }
    }
    Console.WriteLine("Even numbers:");
    Console.WriteLine(string.Join("; ",newArray1));
}
int[] array = new int[10];
InsertValues(array);
PrintArrayOnOneLine(array);
PrintEvenNumbersInNewArray(array);