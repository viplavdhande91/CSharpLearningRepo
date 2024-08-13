using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // call the property getter twice
            var instance1 = Logger.Instance;
            var instance2 = Logger.Instance;

            if (instance1 == instance2 && instance2 == Logger.Instance)
            {
                Console.WriteLine("Instances are the same.");
                Console.ReadLine();
            }

            instance1.Log($"Message from {nameof(instance1)}");
            // or
            instance1.Log($"Message from {nameof(instance2)}");
            // or
            Logger.Instance.Log($"Message from {nameof(Logger.Instance)}");
        }
    }
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {
        //private static Logger? _instance;
        private static readonly Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());

        /// <summary>
        /// Instance
        /// </summary>
        public static Logger Instance
        {
            get { return _lazyLogger.Value; } // This is Object Instantiation.
            //get
            //{
            //    if (_instance == null)
            //    {
            //        _instance = new Logger();
            //    }
            //    return _instance;
            //}
        }

        protected Logger()
        {
            Console.WriteLine("Constructor invoked");
            Console.ReadLine();
        }

        /// <summary>
        /// SingletonOperation
        /// </summary> 
        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
            Console.ReadLine();
        }
    }
}
