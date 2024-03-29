int[] NumberGame(int[] nums)
{
    int[]arr = new int[nums.Length];
    int index = 0;
    var list=nums.ToList().OrderBy(x=>x).ToList();
    while(list.Count>0)
    {
        int num1 = list[0];
        int num2 = list[1];
        Console.WriteLine(index);
        arr[index]=num2;
        index++;
        arr[index]=num1;
        index++;
        list.RemoveRange(0, 2);
    }
    return arr;
}
int[] arr = new int[] { 5, 4, 2, 3 };
var result=NumberGame(arr);
Console.WriteLine(String.Join(",", result));