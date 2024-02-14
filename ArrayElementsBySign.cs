int[] RearrangeArray(int[] nums)
{
    Queue<int> negative = new Queue<int>();
    Queue<int>positive = new Queue<int>();
    foreach(int n in nums)
    {
        if(n > 0)
        {
            positive.Enqueue(n);
        }
        else
        {
            negative.Enqueue(n);
        }
    }
    int[]result=new int[nums.Length];
    for(int i = 0;i<nums.Length;i++)
    {
        if(i%2==0)
        {
            result[i] = positive.Dequeue();
        }
        else
        {
            result[i]=negative.Dequeue();
        }
    }
    return result;
}
int[] nums = new int[] { 3, 1, -2, -5, 2, -4 };
