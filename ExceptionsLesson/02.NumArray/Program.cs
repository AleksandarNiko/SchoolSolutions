int n = 0;
bool isN = false;
while (!isN)
{
    try
    {
        Console.Write("Enter a positive integer number: ");
        n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            throw new Exception("The number must be positive!");
        }
        isN = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid number! Please enter a positive integer number.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

int[] arr = new int[n];
try
{
    InputArray(arr);
    OutputArray(arr);
    Console.WriteLine("The smallest element in the array is: {0}", MinElement(arr));
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("The index is out of range!");
}
catch (FormatException)
{
    Console.WriteLine("Invalid number! Please enter a positive integer number.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
}
        
static void InputArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Enter element {0}: ", i);
        arr[i] = int.Parse(Console.ReadLine());
    }
}

static void OutputArray(int[] arr)
{
    Console.WriteLine("The elements of the array are:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Element {0}: {1}", i, arr[i]);
    }
}

static int MinElement(int[] arr)
{
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

