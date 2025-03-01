
int[] nums = { 1, 2, 3 };
GenerateSubarrays(nums,0,0);

static void GenerateSubarrays(int[] nums, int start, int end)
{
    if (start >= nums.Length)
    {
        return;
    }

    for (int i = start; i < end; i++)
    {
        for (int j = i; j < end; j++)
        {
            for (int k = i; k <= j; k++)
            {
                Console.Write(nums[k] + " ");
            }
            Console.WriteLine();
        }
    }

    GenerateSubarrays(nums, start + 1, end);
}
