using System;
using System.Collections.Generic;

namespace Problems
{
  public class TwoCommonItems
  {
      //['a','b','c','x] , ['z','y''i'] -- > false
      //['a','b','c','X'] , ['z','y''X'] -- > false
    public static bool On2(int[] arr1,int[] arr2)
    {
      foreach(int i in arr1)
      {
        foreach(int j in arr2)
        {
          if(i == j)
          {
            return true;
          }
        }
      }
      return false;
    }
    public static bool On(int[] arr1, int[] arr2)
    {
      Dictionary<int,bool> first = new Dictionary<int, bool>();
      foreach(int i in arr1){first.Add(i,true);};
      foreach(int j in arr2)
      {
        if(first.ContainsKey(j))
        {
          return true;
        }
      }
      return false;
    }
  }
}