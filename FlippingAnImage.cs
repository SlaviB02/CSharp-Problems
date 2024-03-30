using static System.Net.Mime.MediaTypeNames;

int[][] FlipAndInvertImage(int[][] image)
{
    int[][]result = new int[image.Length][];
    for(int i=0;i<image.Length;i++)
    {
        int k = 0;
        result[i]=new int[image[i].Length];
        for(int j = image[i].Length-1; j>=0;j--)
        {
           
            if (image[i][j] == 0)
            {
                result[i][k] = 1;
            }
            else
            {
                result[i][k] = 0;
            }
            k++;
        }
    }
    return result;
}
int[][] matrix = [[1, 1, 0], [1, 0, 1], [0, 0, 0]];
var result=FlipAndInvertImage(matrix);
for (int i = 0; i < result.Length; i++)
{
  
    for (int j = 0; j < result[i].Length;j++)
    {
        Console.Write(result[i][j] + " ");
    }
    Console.WriteLine();
}