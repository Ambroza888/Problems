using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
  class ReverseString
  {
    public static string option1(string str)
    {
      //[hello] [hellh] [oellh]
      char[] s = str.ToCharArray();
      int l = str.Length/2;
      for(int i = 0; i < l ; i++)
      {
        char temp = s[i];
        s[i] = s[s.Length- 1 - i];
        s[s.Length-1- i] = temp;
      }
      return s.ToString();
    }
  }
}