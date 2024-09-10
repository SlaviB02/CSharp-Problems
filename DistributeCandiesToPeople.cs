int[] DistributeCandies(int candies, int num_people)
{
    int[]res=new int[num_people];
    int index = 0;
    int candyNumber = 1;
    while(true)
    {
        if(index==num_people)
        {
            index = 0;
        }
        if(candies<=0)
        {
            break;
        }

        if (candies >= candyNumber)
        {
            res[index] += candyNumber;
            candies -= candyNumber;
            candyNumber++;
            
        }
        else
        {
            res[index]+=candies;
            candies = 0;
        }
        index++;

    }
    return res;
}
int candies = 7, num_people = 4;
var res=DistributeCandies(candies, num_people);
Console.WriteLine(string.Join(",", res));