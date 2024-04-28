bool CheckIfExist(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        int first = arr[i];
        for(int j=i+1;j<arr.Length;j++)
        {
            int second = arr[j];
            if(first==2*second || second==2*first)
            {
                return true;
            }
        }
    }
    return false;
}