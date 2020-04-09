using System;
using System.Collections.Generic;

namespace Problems
{
  public class Say
  {
    public static void SayIt(string[] arr)
    {
      int q = 0;
      foreach(string j in arr)
      {
        for (int i =0; i < arr[q].Length;i++)
        {
          Console.WriteLine(arr[q][i]);
        }
        q++;
      }
    }
  }
}