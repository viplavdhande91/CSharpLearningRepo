using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    // OBSERVER INTERFACE
    public interface INotification
    {
        void Notify();
    }

    //OBSERVER 1
    public class EmailNotification : INotification
    {
        public void Notify()
        {
            System.Console.WriteLine("Email notification code executed");
        }
    }
    //OBSERVER 2

    public class EventNotifcation : INotification
    {
        public void Notify()
        {
            System.Console.WriteLine("Event log notification code executed");
        }
    }
    //OBSERVER 3

    public class SMSNotification : INotification
    {
        public void Notify()
        {
            System.Console.WriteLine("SMS notification code executed");
        }
    }
}
