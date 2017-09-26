using System;
using System.Linq.Expressions;

namespace Common.Logging
{

    public class ILog
    {
        public bool IsDebugEnabled => true;
        public bool IsTraceEnabled => true;
        public bool IsWarnEnabled => true;
        public bool IsInfoEnabled => true;
        public bool IsErrorEnabled => true;

        public void Debug(Action<Action<object, object, object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Debug(Action<Action<object, object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Debug(Action<Action<object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Debug(string p, Exception exception = null) => Console.WriteLine("Log");


        public void Error(Action<Action<object, object, object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Error(Action<Action<object, object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Error(Action<Action<object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Error(string p, Exception exception = null) => Console.WriteLine("Log");

        public void Trace(Action<Action<object, object, object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Trace(Action<Action<object, object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Trace(Action<Action<object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Trace(string p, Exception exception = null) => Console.WriteLine("Log");

        public void Warn(Action<Action<object, object, object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Warn(Action<Action<object, object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Warn(Action<Action<object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Warn(string p, Exception exception = null) => Console.WriteLine("Log");

        public void Fatal(Action<Action<object, object, object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Fatal(Action<Action<object, object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Fatal(Action<Action<object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Fatal(string p, Exception exception = null) => Console.WriteLine("Log");


        public void Info(Action<Action<object, object, object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Info(Action<Action<object, object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Info(Action<Action<object>> p, Exception exception = null) => Console.WriteLine("Log");
        public void Info(string p, Exception exception = null) => Console.WriteLine("Log");

        public void ErrorFormat(string v, params object[] paramameters) => Console.WriteLine("Log");
    }

    public static class LogManager
    {
        public static ILog GetCurrentClassLogger()
        {
            return new ILog();
        }

        public static ILog GetLogger<T>(object data = null)
        {
            return new ILog();
        }
        public static ILog GetLogger(object data = null)
        {
            return new ILog();
        }
    }



    [Serializable]
    public class ConfigurationException : Exception
    {
        public ConfigurationException() { }
        public ConfigurationException(string message) : base(message) { }
        public ConfigurationException(string message, Exception inner) : base(message, inner) { }
        protected ConfigurationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}
