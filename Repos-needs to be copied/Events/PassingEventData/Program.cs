using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingEventData
{
// Most events send some data to the subscribers.The EventArgs class is the base class for all the event data classes.
// .NET includes many built-in event data classes such as SerialDataReceivedEventArgs.    
//It follows a naming pattern of ending all event data classes with EventArgs.You can create your custom class for event data by deriving EventArgs class.
//Use EventHandler<TEventArgs> to pass data to the handler, as shown below.
    class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += EventHandlerProcessCompleted;
            bl.StartProcess();
        }

        public static void EventHandlerProcessCompleted(object sender, bool isSucessful)
        {
            Console.WriteLine("Process" + (isSucessful? "Completed Successfully" : "Failed"));

        }
    }

    public class ProcessBusinessLogic
    {
        public EventHandler<bool> ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine($"Process Started");
            //... some code here
            //OnProcessCompleted(true);
            ProcessCompleted(this, true);
        }

        //protected virtual void OnProcessCompleted(bool isSucessful)
        //{
        //    ProcessCompleted?.Invoke(this, isSucessful);
        //}
    }
}
