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

      string test = "vdgfg";

      Console.WriteLine(reverseString(test));

    }
  }
}