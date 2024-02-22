int FindJudge(int n, int[][] trust)
{
    Dictionary<int,List<int>>people=new Dictionary<int, List<int>>();
    for(int i = 1; i <=n; i++)
    {
       people.Add(i, new List<int>() { 0,0});
    }
    for(int i=0; i < trust.Length; i++)
    {
        var firstP = trust[i][0];
        var secondP = trust[i][1];
        people[firstP][0]++;
        people[secondP][1]++;
    }
    var first= people.FirstOrDefault(x => x.Value[1]==n-1);
    if (first.Value==null || first.Value[0]!=0)
    {
        return -1;
    }
    return first.Key;
}
int n = 3;
int[][]arr= new int[][] { [1, 3], [2, 3], [3,1] };
var result=FindJudge(n, arr);
Console.WriteLine(result);