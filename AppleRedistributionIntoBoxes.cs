int MinimumBoxes(int[] apple, int[] capacity)
{
    int apples = apple.Sum();

    Array.Sort(capacity);

    Array.Reverse(capacity);

    int index = 0;
    while(true)
    {
        if (apples <=0 )
        {
            break;
        }

        apples -=capacity[index];
        index++;
        
    }

    return index;
}
int[] apple = [1, 3, 2], capacity = [4, 3, 1, 5, 2];

int res=MinimumBoxes(apple, capacity);

Console.WriteLine(res);