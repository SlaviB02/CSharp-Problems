var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
IList<IList<string>> result = new List<IList<string>>();
var sortedStrings=new List<string>();

for (int i = 0; i < strs.Length; i++)
{
    char[] temp = strs[i].ToArray();
    Array.Sort(temp);
    var str = new string(temp);
    sortedStrings.Add(str);
  
}
var wordCount=new Dictionary<string, List<int>>();
for(int i = 0;i < sortedStrings.Count;i++)
{
    
    if (wordCount.ContainsKey(sortedStrings[i]))
    {
        wordCount[sortedStrings[i]].Add(i);
    }
    else
    {
        wordCount.Add(sortedStrings[i], new List<int>() {});
        wordCount[sortedStrings[i]].Add(i);
    }

}
foreach(var word in wordCount)
{
    List<string>list=new List<string>();
    for(int i = 0;i<word.Value.Count;i++)
    {
        list.Add(strs[word.Value[i]]);
    }
    result.Add(list);
    
}
return result;
