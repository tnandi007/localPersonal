//Rextester.Program.Main is the entry point for your code. Don't change it.
//Microsoft (R) Visual C# Compiler version 2.9.0.63208 (958f2354)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;

namespace Rextester
{
    public class Program
    {

        public static int[] mergeSortedArray(int[] array1, int[] array2)
        {
            int[] array3 = new int[array1.Length + array2.Length];
            int i = 0, j = 0, k = 0;            
            //i = j = k=0;
            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] < array2[j])
                {
                    array3[k++] = array1[i++]; // assign first then increment; array3[k]=array1[i] ; K++ ; i++
                }
                else
                {
                    array3[k++] = array2[j++];
                }
            }

            while (i < array1.Length)
            {
                array3[k++] = array1[i++];
            }

            while (j < array2.Length)
            {
                array3[k++] = array2[j++];
            }
            return array3;
        }

        public static void Main(string[] args)
        {

            int[] array1 = new int[] {
        2,
        4,
        5,
        7
      };
            int[] array2 = new int[] {
        6,
        9,
        12,
        13
      };

            int[] array4 = mergeSortedArray(array1, array2);
            foreach (int i in array4)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\t");

            List<int> intList = new List<int>();
            intList.AddRange(array1);
            intList.AddRange(array2);
            int[] array3 = intList.ToArray();
            Array.Sort(array3);
            foreach (int i in array3)
            {
                Console.WriteLine(i);
            }

        }
    }
}