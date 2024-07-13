using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous
{
    class Program
    {
        static  async Task Main(string[] args)
        {
            //Console.WriteLine("Step1");
            //Console.WriteLine(DateTime.Now);
            //TestMethodAsync();
            //Console.WriteLine(DateTime.Now);

            //Console.ReadKey();


            //Coffee cup = PourCoffee();
            //Console.WriteLine("coffee is ready");

            //Egg eggs = FryEggs(2);
            Task<Egg> eggsTask1 = FryEggsAsync1(2);// start the FryEggsAsync method
            //Console.ReadKey();
            Thread.Sleep(25000);
            Egg eggs = await eggsTask1;// wait till the task (FryEggsAsync) method is complete
            Console.ReadKey();
            Console.WriteLine("eggs are ready");

            //Bacon bacon = FryBacon(3);
            //Console.WriteLine("bacon is ready");

            //Toast toast = ToastBread(2);
            //ApplyButter(toast);
            //ApplyJam(toast);
            //Console.WriteLine("toast is ready");

            //Juice oj = PourOJ();
            //Console.WriteLine("oj is ready");
            //Console.WriteLine("Breakfast is ready!");
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == eggsTask)
                {
                    Console.WriteLine("eggs are ready");
                }
                else if (finishedTask == baconTask)
                {
                    Console.WriteLine("bacon is ready");
                }
                else if (finishedTask == toastTask)
                {
                    Console.WriteLine("toast is ready");
                }
                breakfastTasks.Remove(finishedTask);
            }

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
            Console.ReadKey();
        }

        static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("ToastBreadAsync: Putting a slice of bread in the toaster");
            }
            Console.WriteLine("ToastBreadAsync: Start toasting...");
            await Task.Delay(3000);
            Console.WriteLine("ToastBreadAsync: Remove toast from toaster");

            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"FryBaconAsync: putting {slices} slices of bacon in the pan");
            Console.WriteLine("FryBaconAsync: cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("FryBaconAsync: cooking the second side of bacon...");
            await Task.Delay(3000);
            Console.WriteLine("FryBaconAsync: Put bacon on plate");

            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("FryEggsAsync: Warming the egg pan...");
            await Task.Delay(3000);
            Console.WriteLine($"FryEggsAsync: cracking {howMany} eggs");
            Console.WriteLine("FryEggsAsync: cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("FryEggsAsync: Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }

        //private static Juice PourOJ()
        //{
        //    Console.WriteLine("Pouring orange juice");
        //    return new Juice();
        //}

        //private static void ApplyJam(Toast toast) =>
        //    Console.WriteLine("Putting jam on the toast");

        //private static void ApplyButter(Toast toast) =>
        //    Console.WriteLine("Putting butter on the toast");

        //private static Toast ToastBread(int slices)
        //{
        //    for (int slice = 0; slice < slices; slice++)
        //    {
        //        Console.WriteLine("Putting a slice of bread in the toaster");
        //    }
        //    Console.WriteLine("Start toasting...");
        //    Task.Delay(3000).Wait();
        //    Console.WriteLine("Remove toast from toaster");

        //    return new Toast();
        //}

        //private static Bacon FryBacon(int slices)
        //{
        //    Console.WriteLine($"putting {slices} slices of bacon in the pan");
        //    Console.WriteLine("cooking first side of bacon...");
        //    Task.Delay(3000).Wait();
        //    for (int slice = 0; slice < slices; slice++)
        //    {
        //        Console.WriteLine("flipping a slice of bacon");
        //    }
        //    Console.WriteLine("cooking the second side of bacon...");
        //    Task.Delay(3000).Wait();
        //    Console.WriteLine("Put bacon on plate");

        //    return new Bacon();
        //}

        private static async Task<Egg> FryEggsAsync1(int howMany)
        {
            Console.WriteLine("Warming the egg pan... at " + DateTime.Now);
            //Task.Delay(3000).Wait();
            await Task.Delay(10000);
            Console.WriteLine($"cracking {howMany} eggs " + DateTime.Now);
            Console.WriteLine("cooking the eggs ... " + DateTime.Now);
            //Task.Delay(3000).Wait();
            await Task.Delay(10000);
            Console.WriteLine("Put eggs on plate " + DateTime.Now);

            return new Egg();
        }

        //private static async void TestMethodAsync()
        //{
        //    await Task.Delay(10000);
        //    Console.WriteLine("TestMethodAsync executed at: " + DateTime.Now);
        //}

        //private static Coffee PourCoffee()
        //{
        //    Console.WriteLine("Pouring coffee");
        //    return new Coffee();
        //}
    }

    internal class Bacon
    {
    }

    internal class Toast
    {
    }

    internal class Juice
    {
    }

    internal class Coffee
    {
    }

    internal class Egg
    {
    }
}
