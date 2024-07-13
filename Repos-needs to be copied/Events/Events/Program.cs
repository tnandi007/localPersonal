using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEvent
{

    public delegate void Notify();

    public class ProcessBusinessLogic //Publisher of the event
    {
        public event Notify ProcessCompleted;//1. Define the event

        public void StartProcess()
        {
            Console.WriteLine($"Process Started");
            //.. some code here
            //OnProcessCompleted();//2. raise the event
            ProcessCompleted();
        }

        //protected virtual void OnProcessCompleted()
        //{
        //    ProcessCompleted?.Invoke(); //calls the event handler in the subscriber class
        //}
    }
       


    class Program //subscriber of the event
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += EventHandlerProcessCompleted; //3. register the event with Event Handler
            bl.StartProcess();
        }

        //4. event handler
        public static void EventHandlerProcessCompleted()
        {
            Console.WriteLine($"Process Completed");
           
        }
    }


}
