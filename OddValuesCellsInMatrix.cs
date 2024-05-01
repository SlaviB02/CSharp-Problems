int OddCells(int m, int n, int[][] indices)
{
    int[,]matrix=new int[m,n];
    for(int i=0; i<indices.Length; i++)
    {
        int index1 = indices[i][0];
        int index2 = indices[i][1];
        for(int z=0;z<n; z++)
        {
            matrix[index1,z]++;
        }
        for(int q=0;q<m; q++)
        {
            matrix[q,index2]++;
        }
    }
    int count = 0;
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            if (matrix[i,j]%2!=0)
            {
                count++;
            }
        }
    }
    return count;
}
int m = 2, n = 3;
int[][] indices = [[0, 1], [1, 1]];
int res=OddCells(m, n, indices);
Console.WriteLine(res);