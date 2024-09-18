int[] RowAndMaximumOnes(int[][] mat)
{
    int[]res= new int[2];
    int max = 0;
    int index = 0;
    for(int i=0; i<mat.Length; i++)
    {
        int ZeroCount = 0;
        for(int j=0; j<mat[i].Length; j++)
        {
            if (mat[i][j]==1)
            {
                ZeroCount++;
            }
        }
        if(max<ZeroCount)
        {
            max=ZeroCount;
            index = i;
        }
    }
    res[0] = index;
    res[1] = max;
    return res;
}
int[][] mat = [[0, 0, 0], [0, 1, 1]];
int[]res=RowAndMaximumOnes(mat);
Console.WriteLine(res[0] + " " + res[1]);