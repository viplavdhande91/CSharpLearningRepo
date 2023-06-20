using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{

    //PUBLISHER /NOTIFIER CLASS /SUBJECT
    public class clsNotifier
    {
        private ArrayList objNotifications = new ArrayList();

        public void addNotification(INotification obj)
        {
            objNotifications.Add(obj);
        }
        public void removeNotification(INotification obj)
        {
            objNotifications.Remove(obj);
        }
        public void NotifyAll()
        {
            foreach (INotification objNotification in objNotifications)
            {
                objNotification.Notify();
            }
        }
    }


    //CLIENT CODE
    class Program
    {

        static void Main(string[] args)
        {
            // This application takes customer code and if
            // the customer code length is above 10 it notifies
            // the error to all the SUBSCRIBERS/OBSERVERS

            // Notifier/Subject to notify all the observers
            clsNotifier objNotifier = new clsNotifier();

            // Add subjects/subscribers which needs to be notified
            EmailNotification objEmailNotification = new EmailNotification();
            EventNotifcation objEventNotification = new EventNotifcation();

            objNotifier.addNotification(objEmailNotification);
            objNotifier.addNotification(objEventNotification);

            // Create a error by entering length more than 10 characters
            Console.WriteLine("Enter Customer Code:");
            string? strCustomerCode = Console.ReadLine();

            // If the length is more than 10 characters[Error Case] notify all subjects/subscribers
            if (strCustomerCode?.Length > 10)
            {
                objNotifier.NotifyAll();
            }

            Console.ReadLine();
        }
    }
}
