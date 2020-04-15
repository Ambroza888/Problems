using System;
using System.Collections.Generic;

namespace Problems
{
  class VesoArray
  {
    public int length = 0;
    public static Dictionary<int,char> data;

    public void get(int index)
    {
      data = new Dictionary<int, char>();
      System.Console.WriteLine( data[index] );
    }
  }
}