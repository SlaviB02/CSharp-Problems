int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
{
    return hours.Where(x=>x>=target).Count();
}