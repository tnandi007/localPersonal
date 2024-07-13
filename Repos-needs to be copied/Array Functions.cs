//Rextester.Program.Main is the entry point for your code. Don't change it.
//Microsoft (R) Visual C# Compiler version 2.9.0.63208 (958f2354)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;
using System.Text;

namespace Rextester {
  public class Program {
    static string reverseString(string s) {
      // Frequency of each character
      int[] freq = new int[26];
      int count = 0;
      StringBuilder sb = new StringBuilder();
      // Loop to count the frequency
      // of each character of the String
      for (int i = 0; i < s.Length; i++) {
        freq[s[i] - 'a']++;
      }

      for (int i = 0; i < freq.Length; i++) {
        for (int j = 0; j < freq[i]; j++) {
          sb.Append((char)('a' + i));
          //Console.WriteLine((char)('a' + i));                    
        }
      }

      return sb.ToString();
    }

    public static void Main(string[] args) {

      // var stringArr=new string[]{"ram", "Jadu", "Madhu"};
      string[] stringArr = {
        "ram",
        "Jadu",
        "Madhu",
        "Madhu"
      };

      string[] matchedNames = Array.FindAll(stringArr, name => name == "Madhu");
      Array.ForEach(matchedNames, name => Console.WriteLine(name));

      var find = Array.Find(stringArr, str => str == "Jadu");
      Console.WriteLine(find);

      string test1 = String.Join(",", stringArr);
      Console.WriteLine(test1);

      //string[] distinct=stringArr.Distinct().ToArray();
      var distinct = stringArr.Distinct().ToArray();
      Array.ForEach(distinct, n => Console.WriteLine(n));

      string test = "vdgfg";

      //Console.WriteLine(reverseString(test));

      Console.WriteLine();

      string s = "?[])({}??()))";
      string s1 = "bcadfnk";
      char[] charArray = s.ToCharArray();
      Array.Sort(charArray);
      
    }
  }
}