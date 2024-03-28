int KthSmallest(int[][] matrix, int k)
{
    List<int> result = new List<int>();
    for(int i = 0; i < matrix.Length; i++)
    {
        for(int j=0; j < matrix[i].Length; j++)
        {
            result.Add(matrix[i][j]);
        }
    }
    var sorted=result.OrderBy(x => x).ToList();
    return sorted[k - 1];
}
int[][] matrix = [[1, 5, 9], [10, 11, 13], [12, 13, 15]];
int k = 8;
Console.WriteLine(KthSmallest(matrix,k));