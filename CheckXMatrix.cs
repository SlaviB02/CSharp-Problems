bool CheckXMatrix(int[][] grid)
{
    for(int i=0; i<grid.Length; i++)
    {
        for(int j=0; j < grid[i].Length; j++)
        {
           if(i==j || (i + j) == grid.Length - 1)
            {
                if (grid[i][j] == 0) { return false; }
            }

            else if (grid[i][j] !=0) { return false; }
        }
    }
    return true;
}