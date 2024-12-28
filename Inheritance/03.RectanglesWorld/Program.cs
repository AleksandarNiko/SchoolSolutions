
using _03.RectanglesWorld;

var squares=new List<Square>();
var rectangles=new List<Rectangle>();

ReadingAndSeedingLists(squares, rectangles);

Console.WriteLine(squares.Count);
Console.WriteLine(rectangles.Count);

static void ReadingAndSeedingLists(List<Square> squares, List<Rectangle> rectangles)
{
    while (true)
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        if (nums[0] == 0)
        {
            break;
        }

        if (nums.Length > 2)
        {
            Console.WriteLine("You should enter two values!");
            break;
        }

        if (nums[0] == nums[1])
        {
            squares.Add(new Square(nums[0]));
        }
        else
        {
            rectangles.Add(new Rectangle(nums[0], nums[1]));
        }
    }
}