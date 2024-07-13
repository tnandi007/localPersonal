using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscellanious
{
    internal class Program
    {
        Dictionary<char,int> map = new Dictionary<char,int>();

         bool isUnique(string str)
        {
            foreach(char c in str)
            {
                if (map.ContainsKey(c)) { return false; }
                else map.Add(c, 1);
            }
           //IEnumerable<bool> tt= map.Select(c => c.Value>0).Where(d=> d.Equals(true));
           // if (tt.Count() > 0)
           //     return false;
            return true;
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            string str="abcdeff";
            int val = str[0];
            bool isUnique = p.isUnique(str);
            char[] arr = str.ToCharArray();
            int len=arr.Length;
            Array.Reverse(arr);
            
            //arr=arr.Reverse();
            IEnumerable<char> chars=arr.Distinct();
            if (arr.Length > chars.Count())
            {
                Console.WriteLine("String does not have unique chars");
            }

            string str1 = "test test1 test2";
            int len1 = str1.Split(Convert.ToChar(" ")).Length;
            double val1 = char.GetNumericValue('5');
            int val2 = 'a';

        }
    }
}
