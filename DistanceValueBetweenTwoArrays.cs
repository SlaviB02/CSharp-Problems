int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        bool flag = true;
        for (int j = 0; j < arr2.Length; j++)
        {
            int value=Math.Abs(arr1[i] - arr2[j]);
            if(value<=d)
            {
                flag = false;
                break;
            }
        }
        if (flag)
        {
            count++;
        }
    }
    return count;
}
int[] arr1 = [4, 5, 8], arr2 = [10, 9, 1, 8];
int d = 2;
int res=FindTheDistanceValue(arr1, arr2, d);  
Console.WriteLine(res);