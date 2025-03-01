
int n = int.Parse(Console.ReadLine());
TriangleWithStars(n);


static void TriangleWithStars(int starsCount)
{
    if (starsCount > 0)
    {
        TriangleWithStars(starsCount - 1);
        Console.WriteLine(new string('*', starsCount));
    }
    else
    {
        return;
    }
}
