int DifferenceOfSum(int[] nums)
{
    int ElementSum=nums.Sum();

    int DigitSum = 0;

    string numbers = "";

    for (int i = 0; i < nums.Length; i++)
    {
        numbers += nums[i];
    }

    for(int i=0;i<numbers.Length;i++)
    {
        DigitSum +=int.Parse(numbers[i].ToString());
    }

    return Math.Abs(ElementSum-DigitSum);
}

int[] nums = [1, 15, 6, 3];
int res=DifferenceOfSum(nums);

Console.WriteLine(res);