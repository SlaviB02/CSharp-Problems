int HeightChecker(int[] heights)
{
    int[]expected=heights.ToArray();

    Array.Sort(expected);


    int count = 0;

    for(int i= 0; i < expected.Length; i++)
    {
        if(expected[i] != heights[i])
        {
            count++;
        }
    }


    return count;
}

int[] heights = [1, 1, 4, 2, 1, 3];
int res=HeightChecker(heights);
Console.WriteLine(res);