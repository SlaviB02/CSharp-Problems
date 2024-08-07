int MinOperations(int[] nums, int k)
{
    int count = 0;
    List<int>list = new List<int>(nums);
    list.Sort();
    while(true)
    {
        if(list.Count==0)
        {
            break;
        }
        if (list[0]<k)
        {
            list.RemoveAt(0);
            count++;
        }
        else
        {
            break;
        }

    }
    return count;
}
int[] nums = [2, 11, 10, 1, 3];
int k = 10;
int result=MinOperations(nums, k);
Console.WriteLine(result);