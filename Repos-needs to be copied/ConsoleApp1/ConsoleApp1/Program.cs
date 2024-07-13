using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Node
    {
        public Node next = null;
        public int Data;
        public Node(int d)
        {
            Data = d;
        }


        public Node Push(Node head, int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return head;
            }
            newNode.next = head;
            head = newNode;
            return head;

        }
        public Node remove(Node head, int val)
        {
            Node tobeDeleted = head;
            Node prev = null;
            while (tobeDeleted != null)
            {
          
                if (tobeDeleted.Data==val)
                {
                    if (prev == null)
                    {
                        head = tobeDeleted.next;
                        break;
                    }
                    prev.next = tobeDeleted.next;
                    //Node temp = tobeDeleted;
                    tobeDeleted = null;
                    break;
                }

                prev = tobeDeleted;

                tobeDeleted = tobeDeleted.next;
            }
            return head;
        }

        public Node removeLastNode(Node head)
        {
            //while (head.next.next != null)
            //{
            //   head.Data=head
            //}
            //return head;
            if (head == null)
                return null;

            if (head.next == null)
            {
                return null;
            }

            // Find the second last node
            Node second_last = head;
            while (second_last.next.next != null)
                second_last = second_last.next;

            // Change next of second last
            second_last.next = null;

            return head;
        }
    }
    class Small
    {
    }

    class Big : Small
    {
    }

    class Testing
    {
        public List<int> MyList { get; set; }
    }

     class Parent
    {
        public Parent()
        {
            //Console.WriteLine("Hello from Parent");
            this.TestMethod();
        }

        public void TestMethod()
        {
            Console.WriteLine("Hello from Parent");
        }
        
    }

    class Dervied:Parent
    {

        public new void TestMethod()
        {
            Console.WriteLine($"Hello from Derived");
        }

    }

    class Program
    {


        public delegate void Delegate1(Big bg);

        static void Method1(Big big)
        {
        }

        static void Method2(Small sml)
        {
        }

        

        class Animal  // Base class (parent) 
        {
            public void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig : Animal  // Derived class (child) 
        {
            public void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Animal  // Derived class (child) 
        {
            public void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }
        class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }

            //public Student(int StudentID, string StudentName, int Age)
            //{
            //    this.StudentID = StudentID;
            //    this.StudentName = StudentName;
            //    this.Age = Age;
            //}

        }
        abstract class Page
        {
        }

        class Page1 : Page
        {
        }
        class Page2 : Page
        {
        }
        abstract class Document
        {
            private List<Page> _pages = new List<Page>();

            public List<Page> Pages
            {
                get { return _pages; }
            }

            public abstract void CreatePage();
        }

        class DocCreator: Document{

            public DocCreator()
            {
                this.CreatePage();
            }
            public override void CreatePage()
            {
                Pages.Add(new Page1());
                Pages.Add(new Page2());
            }
        }

        public class Test
        {

            public string Name { get; set; }

        }
        public delegate int MyDelegate(string str);

        public static int Method1(string str)
        {
            return int.Parse(str);
        }
        public static void Implementor(MyDelegate del)
        {
            del("100");
        }
        static void Main(string[] args)
        {
            bool getValue = 2 > 4 ? true : false;

            if (!(5==5 && 6==6))
            {
                Console.WriteLine($"test");
            }

            Parent p = new Dervied();
            Parent p2 = new Parent();
           // Dervied d = new Parent();
            p.TestMethod();
            Testing testObj = new Testing();
            //testObj.MyList.

            List<List<int>> listlist = new List<List<int>>();
            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            
            listlist.Add(list1);

            List<int>[] arrn = listlist.ToArray();

            Small sm = new Big();
            Small sm1 = new Big();
            Big bg = (Big)sm1;
            //Method1(sm);// Method1 expect Big object so cant pass Small object as method parameter while calling the function directly. Delegate can overcome this.
            Delegate1 dg = Method1;//cotravariance
            dg += Method2;
            //dg()
            Method2(bg);
            //int num22 = 3%2;

            Node head = new Node(5);
            head=head.Push(head, 12);
            head=head.Push(head, 29);
            head=head.Push(head,11);
            head=head.Push(head, 23);
            head=head.Push(head, 8);

            //8->23->11->29->12->5->null
            //head = head.removeLastNode(head);
            head = head.remove(head, 11);

            //int[] storeSum = new int[] { };
           
            //int cntr = 0;
            List<int> storeSum = new List<int>();
            //while(head!=null)
            //{
            //    Node runner = head;
            //    while (runner.next.next!=null)
            //    {
            //        runner = runner.next;
            //    }
            //    storeSum.Add(runner.next.Data + head.Data);
            //    runner.next = null;
            //    head = head.next;
            //}
            Node current = head;
            while (current != null)
            {
                Node runner = current;
                while (runner.next.next != null)
                {
                    runner = runner.next;
                }
                storeSum.Add(runner.next.Data + current.Data);
                runner.next = null;
                current = current.next;
            }

            int[] arr = new int[] { 5,8,7,4,2};

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length-1; j++)
                {
                    if (arr[i]>arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
            }

            Array.ForEach(arr, n => Console.WriteLine(n.ToString()));
            var test = new Test() {Name="Tatha"};

            MyDelegate del = Method1;
            Implementor(del);
            del("100");

            Animal myAnimal = new Animal();  // Create a Animal object
            Pig myPig = new Pig();  // Create a Pig object
            Dog myDog = new Dog();  // Create a Dog object

            Animal myPig1 = new Pig();  // Create a Pig object
            Animal myDog1 = new Dog();

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            myPig1.animalSound();
            myDog1.animalSound();

            Document[] documents = new Document[2];
            documents[0] = new DocCreator();
            documents[1] = new DocCreator();


            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                    Console.WriteLine();
                }
            }


            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
                     };
            var orderedList = studentList.OrderBy(s => s.StudentName);
            var orderedList1 = from s in studentList
                               orderby s.StudentName
                               select s.StudentName;
            var teenAgerStudents = studentList.Where(s => s.Age > 12 && s.Age < 20).ToList<Student>();
                                
            string[] names = { "Adam", "Gopi", "Rekha", "Vikas", "Abdul" };
            var title = new string[] { "Nandi", "Saha", "Paul", "Dey" };

            var myLinqQuery = from n in names
                              where n.Contains("A")
                              select n;
            string[] newarr = myLinqQuery.ToArray();
            Array.ForEach(newarr, s => Console.WriteLine(s));
            //foreach (int i in Enumerable.Range(5, 3)) Console.Write(i + "");
            Console.Read();
        }
    }
}
