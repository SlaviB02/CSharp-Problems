using System.Collections.Generic;
using System.Linq;
using System;
					
public class Program
{
	public static string[] SortPeople(string[] names, int[] heights) {
        Dictionary<int,string> result=new Dictionary<int,string>();
      for(int i=0;i<names.Length;i++)
      {
        result.Add(heights[i],names[i]);
      }
      string[]res=new string[names.Length];
      int index=0;
      var ordered=result.OrderByDescending(x=>x.Key).ToDictionary(e => e.Key,e => e.Value);
      foreach(var item in ordered.Values)
      {
        res[index]=item;
        index++;
      }
      return res;
    }
	public static void Main()
	{
		string[]names =new string[]{"Mary","John","Emma"};
		int[] heights = new int[]{180,165,170};
		string[]result=SortPeople(names,heights);
		 foreach(var item in result)
		 {
            Console.WriteLine(item);
         }
	}
}
