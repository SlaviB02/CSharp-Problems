string[] UncommonFromSentences(string s1, string s2)
{
    List<string>res= new List<string>();
   Dictionary<string,int>words1= new Dictionary<string,int>();
    Dictionary<string,int>words2=new Dictionary<string,int>();
    string[]stringOne=s1.Split(' ');
    string[]stringTwo = s2.Split(' '); 
    for(int i=0;i<stringOne.Length;i++)
    {
        if (words1.ContainsKey(stringOne[i]))
        {
            words1[stringOne[i]]++;
        }
        else
        {
            words1.Add(stringOne[i], 1);
        }
    }
    for (int i = 0; i < stringTwo.Length; i++)
    {
        if (words2.ContainsKey(stringTwo[i]))
        {
            words2[stringTwo[i]]++;
        }
        else
        {
            words2.Add(stringTwo[i], 1);
        }
    }

  var words1Ordered = words1.Where(x => x.Value == 1).ToDictionary();
  var words2Ordered=words2.Where(x=>x.Value==1).ToDictionary();
    foreach(var kvp in words1Ordered)
    {
        if(!words2.ContainsKey(kvp.Key))
        {
            res.Add(kvp.Key);
        }
    }
    foreach(var kvp in words2Ordered)
    {

        if (!words1.ContainsKey(kvp.Key))
        {
            res.Add(kvp.Key);
        }
    }
    return res.ToArray();
}
string s1 = "this apple is sweet", s2 = "this apple is sour";
var res=UncommonFromSentences(s1,s2);
Console.WriteLine(string.Join(",",res));