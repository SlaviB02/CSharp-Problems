int PeakIndexInMountainArray(int[] arr)
{
    int index = 0;
    int temp = arr[0];
    for(int i=1; i<arr.Length; i++)
    {
        if (temp < arr[i])
        {
            temp = arr[i];
        }
        else
        {
            index = i-1;
            break;
        }
    }
    return index;
}
int[] arr = [0, 1, 0];
int res=PeakIndexInMountainArray(arr);
Console.WriteLine(res);