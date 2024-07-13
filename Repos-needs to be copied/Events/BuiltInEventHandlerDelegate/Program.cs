using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInEventHandlerDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += EventHandlerProcessCompleted;
            bl.StartProcess();
        }

        public static void EventHandlerProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine($"Process Completed!");

        }
    }

    public class ProcessBusinessLogic
    {
        public EventHandler ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine($"Process Started");
            //... some code here
            OnProcessCompleted(EventArgs.Empty);
        }

        protected virtual void OnProcessCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
    }
}
