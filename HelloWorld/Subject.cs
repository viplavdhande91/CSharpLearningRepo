namespace Observer
{
    public interface ISubject
    {
        void addNotification(INotification obj);
        void NotifyAll();
        void removeNotification(INotification obj);
    }

    public class Subject : ISubject
    {
        private IList<INotification> objNotifications = new List<INotification>();

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
}
