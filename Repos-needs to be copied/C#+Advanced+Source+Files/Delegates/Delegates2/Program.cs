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
            //int i= delegate(x,y)=> return x+y;
            //Task.Factory.StartNew((q) => Console.WriteLine(q));
            //Action action = (q) => Console.WriteLine(q);
            //action(5);
            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select((q) => q * q);
            Console.WriteLine(string.Join(" ", squaredNumbers));
            List<Employee> employees = new List<Employee>() 
            {new Employee { ID=103, Gender="Male",Name="Test",Salary=200},
             new Employee{ID = 104, Gender = "Male", Name = "Test1", Salary = 200 },
             new Employee{ID = 105, Gender = "Male", Name = "Test2", Salary = 200 } };
            //Employee emp = new Employee() { ID = 103, Gender = "Male", Name = "Test", Salary = 200 };
            Employee employee = employees.Find((n)=>n.ID==103);

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

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
    }


}
