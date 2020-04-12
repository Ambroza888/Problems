using System;
using System.Collections.Generic;

namespace Problems
{
  class TwoSum
  {
    public static bool Naive(int[] arr, int sum)
    {
      for(int i = 0; i < arr.Length;i++)
      {
        for(int j = i+1; j < arr.Length; j++)
        {
          if(arr[i] + arr[j] == sum)
          {
            return true;
          }
        }
      }
      return false;
    }
  }
}