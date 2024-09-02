int[][] Construct2DArray(int[] original, int m, int n)
{
    if(m*n!=original.Length)
    {
        return new int[0][];
    }
    int[][]res= new int[m][];
    int index = 0;
    for (int i = 0; i < m; i++)
    {
        res[i]=new int[n];
        for (int j = 0; j < res[i].Length; j++)
        {
            res[i][j] = original[index];
            index++;
        }
    }
    return res;
}
int[] original = [1, 2, 3, 4];
int m = 2, n = 2;
var res=Construct2DArray(original, m, n);
for (int i = 0; i < res.Length; i++)
{
    for(int j = 0; j < res[i].Length;j++)
    {
        Console.Write(res[i][j] + " ");
    }
    Console.WriteLine();
}
