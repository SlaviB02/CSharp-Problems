int MinMovesToSeat(int[] seats, int[] students)
{
    int count = 0;
    Array.Sort(seats);
    Array.Sort(students);
      for(int i=0;i<seats.Length;i++)
    {
        int move = 0;
        if (seats[i] > students[i])
        {
            move = 1;
        }
        else
        {
            move = -1;
        }
        while (seats[i] != students[i]) 
        {
            students[i]+=move;
            count++;
        }
    }
    return count;
}
int a = MinMovesToSeat(new int[] { 3, 1, 5 }, new int[] { 2, 7, 4 });
Console.WriteLine(a);