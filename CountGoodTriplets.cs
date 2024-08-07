int CountGoodTriplets(int[] arr, int a, int b, int c)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            for (int x = j + 1; x < arr.Length; x++)
            {
                int first = arr[i];
                int second = arr[j];
                int third = arr[x];
                if(Math.Abs(first-second)<=a && Math.Abs(second-third)<=b && Math.Abs(first-third)<=c)
                {
                    count++;
                }
            }
        }
    }
    return count;

}
int []arr = [3, 0, 1, 1, 9, 7];
int a = 7;
int b = 2;
int c = 3;
int count=CountGoodTriplets(arr, a, b, c);
Console.WriteLine(count);