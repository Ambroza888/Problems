using System;
using System.Collections.Generic;

namespace Problems
{
  public class Say
  {
    public static void SayIt(int[] arr)
    {
      //[1,2,3,4,5] 
      for(int i = 0; i < arr.Length;i++)
      {
        for(int j = i+1; j < arr.Length+1;j++)
        {
          System.Console.WriteLine($"i is : {arr[i]} and j is {arr[j]} and total is {arr[i] + arr[j]}");
        }
      }
    }
  }
}