int[] XorQueries(int[] arr, int[][] queries)
{
    int[]res= new int[queries.Length];
    for(int i=0;i<queries.Length;i++)
    {
        int start=queries[i][0];
        int end=queries[i][1];
        int xor = arr[start];
            for (int j = start + 1; j <= end; j++)
            {
                xor ^= arr[j];
            }
 
        res[i]=xor;
    }
    return res;
}
int[] arr = [1, 3, 4, 8];
int[][] queries = [[0, 1], [1, 2], [0, 3], [3, 3]];
int[]res=XorQueries(arr, queries);
Console.WriteLine(string.Join(",", res));