
using System;

namespace Delegates
{
    class Program
    {
        public delegate void Test(string str);
        static void Main(string[] args)
        {
            //Test del = TestMethod;
            //del("hello");
            //string s1 = "Tathagata";
            //string s2 = "Nandi";
            //Console.WriteLine($"{s1}-{s2}");
            //Console.WriteLine(String.Concat(s1,"-",s2));

        
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);
            //processor.Process("photo.jpg",filters );
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
            
        }

        static void TestMethod(string str)
        {
            Console.WriteLine("Hello World");
        }

       
    }
}
