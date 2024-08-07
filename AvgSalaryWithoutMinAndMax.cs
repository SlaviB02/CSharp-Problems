double Average(int[] salary)
{
    int max=salary.Max();
    int min=salary.Min();
    List<int>result =salary.Where(x=>x!=max && x!=min).ToList();
    return result.Average();
}
int[] salary = [4000, 3000, 1000, 2000];
double avg=Average(salary);
Console.WriteLine(avg);