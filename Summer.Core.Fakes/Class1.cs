using System;

namespace Common.Logging
{
    public interface ILog
    {
        void Debug(Func<object, object> p);
    }

    public class Log : ILog
    {
        public void Debug(Func<object, object> p)
        {
            
        }
    }

    public static class LogManager
    {
        public static ILog GetLogger<T>()
        {
            return new Log();
        }
    }
}
