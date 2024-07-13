using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyFileSearch x = new MyFileSearch();
            //x.searchMethodDelegate
            x.searchMethodDelegate = Subscriber1;
            x.searchMethodDelegate += Subscriber2;
            Console.WriteLine("File Search started");

            //await x.Search(@"C:\MyFolder");
            Task.Run(()=>x.Search(@"\\sourcetrac-fsx-dev-qa.r1-core.r1.aig.net\share\DEV\AWD\PPS_Images\copy\2022-06-19"));

            Console.WriteLine("Continue executing main function.....");

            Console.ReadLine();
        }

        public static void Subscriber1(string filename)
        {
            Console.WriteLine(filename);
        }

        public static void Subscriber2(string filename)
        {
            Console.WriteLine(filename);
        }
    }

    public class MyFileSearch
    {
        public delegate void searchMethod(string search);
        public searchMethod searchMethodDelegate= null;
        //Program p = new Program();
        
        public void Search(string dir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(dir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {

                        searchMethodDelegate(f);
                        //Program.Subscriber1(f);
                        //Program.Subscriber2(f);
                      
                    }

                }

          

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        

    }

    
}
