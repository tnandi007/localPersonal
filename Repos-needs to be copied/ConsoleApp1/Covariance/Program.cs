using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance
{
    class Small
    {
    }
    class Big : Small
    {

    }

    class Program
    {
        public delegate void Delegate1(Big bg);
        public delegate int Delegate2(int value);
        //public delegate void Delegate1(Small sm);

        static void Method1(Big big)
        {
            Console.WriteLine(big.GetType().ToString());
        }
        static void Method2(Small sml)
        {
            Console.WriteLine(sml.GetType().ToString());
        }
        static void Main(string[] args)
        {

            //delegate bool del1(string s);
            Delegate2 del = delegate (int num) { return num; };
            Delegate2 del1 = num => num;
            Console.WriteLine(del1(2));
            var intArray = new int[] { 4,6,8,10,12};
            intArray.Reverse();
            //int i= intArray.FirstOrDefault();
            Array.ForEach(intArray, element => Console.WriteLine(element));
            Array.ForEach(intArray, element => element=element * 2);
            intArray.Select(x => x * x);
            var intArray1 = new int[] { 14, 16, 18, 20, 22, 24};

            Array.Copy(intArray, intArray1, 4);

            string nameString = "tatha";
            //converting String to Char Array
            char[] nameArray = nameString.ToCharArray(); // euivalent to  char[] name = new char[] {'t','a','t','h','a' };
            //converting char array to string
            //all below 3 statements results into a string ="tatha"
            nameString = string.Join("", nameArray); 
            nameString = new string(nameArray);
            nameString = string.Concat(nameArray);
            
            string s = "nandi";
            char[] charArray = s.ToArray();
            char temp = charArray[0];
            charArray[0] = charArray[charArray.Length - 1];
            charArray[charArray.Length - 1] = temp;
            s = new string(charArray);
            s = String.Concat(charArray);

            //char c = s[0];
            //s[0] = 'k';
            //s[0] = s[s.Length - 1];
            


            string manyLines = @"This is line one
            This is line two
            Here is line three
            The penultimate line is line four
            This is the final, fifth line.";

            using (var reader = new StringReader(manyLines))
            {
                string item;
                do
                {
                    item = reader.ReadLine();
                    Console.WriteLine(item);
                } while (item != null);
            }

            Small sm = new Big();
            Small sm1 = new Big();
            Big bg = (Big)sm1;
            //Method1(sm);// Method1 expect Big object so cant pass Small object as method parameter while calling the function directly. Delegate can overcome this.
            Delegate1 dg = Method1;//cotravariance
            dg += Method2;
            //Delegate1 dg = Method2;
            //dg += Method1;

            //dg(sm);
            Method2(bg);
        }
    }
}
