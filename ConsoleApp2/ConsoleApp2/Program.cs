// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var obj = new Subchild();
obj.MethodTest();
Console.ReadLine();

int i; 
Test(in i);
var student=new Student();
student.Name = "John";
student.Age = 10;
ChangeStudent(out student);
Console.ReadKey();
static void Test(in int i)
{
    //i++; given error - Cant change the value
    //i = 1;
    //i=i+1;
    i = 2;
    Console.WriteLine(i);
}
static void ChangeStudent(out Student student)
{
    //student.Name = "John-Chnaged";
    student = new Student();
    student.Age = 15;
}

//Console.ReadKey();

public class Parent
{
    virtual public void MethodTest()
    {
        Console.WriteLine("Called from Parent Class");
    }
}

public class Child : Parent 

{
    public override void MethodTest()
    {
        Console.WriteLine("Called from Child Class");
    }

    public virtual void SomeMethod()
    {
        Console.WriteLine("SomeMethoc Called from Child Class");
    }
}

public class Subchild :Child
{
    public override void MethodTest()
    {
        base.MethodTest();
        Console.WriteLine("Called from SubChild Class");
    }
    
}

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}


