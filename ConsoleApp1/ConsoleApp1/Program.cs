// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
TestD.Check1();
//Doctor d=new Doctor();
d.CheckPatient();
 var myclassObj=new MyClass();
myclassObj.Print();
Console.WriteLine(myclassObj.i.ToString()); 
Console.ReadLine();
string original = "tnandi";
string output=original[original.Length-1]
    +original.Substring(1,original.Length-2)
    +original[0];
Console.WriteLine(output);
List<Point> points1 = new List<Point>() { new Point(1,2,3), new Point(4,5,6), new Point(3,2,4) };
points1.Sort();

//List<List<int>> points = new List<List<int>>() { new List<int>() {1,2}, new List<int>() {1,-1}, new List<int>() { 3,4 } } ;
List<List<int>> points = new List<List<int>>() { new List<int>() { 1, 3 }, new List<int>() { -3, 1 } };
List<List<int>> result = kclosest(points, 2);

var test= (int x, int y) => x>y;
Console.WriteLine(test);
Console.WriteLine(test(2,3));
Console.ReadLine();
//;

static List<List<int>> kclosest(List<List<int>> points, int k)
{
    List<List<int>> result = new List<List<int>>(); // = new int[k][2];
    List<Point> pointslist = new List<Point>();
    foreach(List<int> point in points)
    {
        double distance = Math.Sqrt((point[0] * point[0]) + (point[1] * point[1]));
       // Point pt =new Point(1,2,3);
        pointslist.Add(new Point( point[0], point[1], distance ));
    }

    //var descendingComparer = Comparer<int>.Create((x, y) => y.CompareTo(x));
    var PointComparer = Comparer<Point>.Create((p1, p2) =>
    {
        if (p1.distance.CompareTo(p2.distance) == 0)
        {
            //return Math.Abs(p1.x).CompareTo(Math.Abs(p2.x));
            return p1.x.CompareTo(p2.x);
        }
        else
        {
            return p1.distance.CompareTo(p2.distance);
            //return 0;
        }
   });
    pointslist.Sort(PointComparer);
    //pointslist.Sort(new PointCompare());
    //    for (int[] point : points) {
    //    double distance = math.sqrt((point[0] * point[0]) + (point[1] * point[1]));
    //    pointslist.add(new point(point[0], point[1], distance));
    //                }
    //collections.sort(pointslist, (p1, p2)-> {
    //    if (p1.distance == p2.distance)
    //    {
    //        return p1.x - p2.x;
    //        // if question is looking for nearest point with x value, regardless of whether x value is positive or negative
    //        // then return math.abs(p1.x) - math.abs(p2.x);
    //    }
    //    else
    //        return double.compare(p1.distance, p2.distance);
    //});
    for (int i = 0; i < k; i++)
    {
        result.Add(new List<int>() { pointslist[i].x, pointslist[i].y });
    }
    return result;
}

public class PointCompare : IComparer<Point>
{
    public int Compare(Point p1, Point p2)
    {
        if (p1.distance.CompareTo(p2.distance) == 0)
        {
            return Math.Abs(p1.x).CompareTo(Math.Abs(p2.x));
        }        
        else
        {
            return p1.distance.CompareTo(p2.distance);
            //return 0;
        }
        
    }
}

public class Point : IComparable<Point>
{
    public int x;
    public int y;
    public double distance;

    public Point(int x, int y, double distance)
    {
        this.x = x;
        this.y = y;
        this.distance = distance;
    }

    public int CompareTo(Point? other)
    {
        return this.x.CompareTo(other.x);
    }
}
class MyClass
{
    public int i;

    public void Print()
    {
        int d;
        //Console.WriteLine(d);
    }
}
public class Test
{
    protected string str="Test";

    protected void testMethod()
    {
        Console.WriteLine("Called fro Base class");
    }
}

public class TestC : Test
{
    
    public  void  Check()
    { 
        TestC t = new TestC();
        Console.WriteLine(base.str);
    }

    new void testMethod()
    {
    }
}

public class TestD : TestC
{

    public static void Check1()
    {
        TestD t = new TestD();
        Console.WriteLine(t.str);
    }

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

class Person
{
    public int age;
    public string name;

    public Person(int age, string name)
    {
        this.age = age;
        this.name = name;
    }
}

class Doctor: Person
{
    public Doctor(int age, string name) : base(age, name)
    {
    }

    public void CheckPatient() => Console.WriteLine("Yes");
}

public class A // This is the base class.
{
    public A(int value)
    {
        // Executes some code in the constructor.
        Console.WriteLine("Base constructor A()");
    }
}

public class B : A // This class derives from the previous class.
{
    public B(int value)
        : base(value)
    {
        // The base constructor is called first.
        // ... Then this code is executed.
        Console.WriteLine("Derived constructor B()");
    }
}

