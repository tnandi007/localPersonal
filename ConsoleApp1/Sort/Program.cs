// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


 static void fizzBuzz(int n)
{
    for (int i = 1; i <= n; i++)
    {

        switch (i)
        {
            case (i % 3 == 0 && i % 5 == 0):
                Console.WriteLine("FizzBuzz");
                continue;
            case ((i % 3 == 0 && i % 5 != 0)):
                Console.WriteLine("Fizz");
                continue;
            case ((i % 3 != 0 && i % 5 != 0)):
                Console.WriteLine("Buzz");
                continue;
            default:
                Console.WriteLine(i);
                continue;

        }


    }
}

}