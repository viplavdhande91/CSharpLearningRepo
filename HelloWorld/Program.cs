namespace Observer
{
    //CLIENT CODE
    class Program
    {
        static void Main(string[] args)
        {
            // This application takes customer code and if
            // the customer code length is above 10 it notifies
            // the error to all the SUBSCRIBERS/OBSERVERS

            // Notifier/Subject to notify all the observers
            Subject sub = new Subject();

            // Add subjects/subscribers which needs to be notified
            EmailNotification objEmailNotification = new EmailNotification();
            EventNotifcation objEventNotification = new EventNotifcation();

            sub.addNotification(objEmailNotification);
            sub.addNotification(objEventNotification);

            // Create a error by entering length more than 10 characters
            Console.WriteLine("Enter Customer Code:");
            string? strCustomerCode = Console.ReadLine();

            // If the length is more than 10 characters[Error Case] notify all subjects/subscribers
            if (strCustomerCode?.Length > 10)
            {
                sub.NotifyAll();
            }

            Console.ReadLine();
        }
    }
}
