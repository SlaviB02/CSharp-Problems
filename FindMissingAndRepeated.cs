int[] FindMissingAndRepeatedValues(int[][] grid)
{
    int[] res = new int[2];
    
    List<int>numbers= new List<int>();
    for(int i = 0; i < grid.Length; i++)
    {
        for(int j=0; j < grid[i].Length; j++)
        {
           
            if (!numbers.Contains(grid[i][j]))
            {
                numbers.Add(grid[i][j]);
            }
            else
            {
                
                res[0] = grid[i][j];
            }
        }
    }
    int left = 1;
    int right = grid.Length * grid.Length;
    while(true)
    {
        if (!numbers.Contains(left))
        {
            res[1] = left;
            break;
        }
        if(!numbers.Contains(right))
        {
            res[1] = right;
            break;
        }
        left++;
        right--;
    }
    return res;

}
int[][] grid = [[1, 3], [2, 2]];
int[] res = FindMissingAndRepeatedValues(grid);
Console.WriteLine(res[0] + "  " + res[1]);