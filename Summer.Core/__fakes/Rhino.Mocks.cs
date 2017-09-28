using System;
using System.Linq.Expressions;
using Spring.Context;
using Spring.Globalization;

namespace Rhino.Mocks
{
    public class _ { }

    public class MockRepository
    {
        public object PartialMock(Type type, IFormatter formatter = null)
        {
            return Activator.CreateInstance(type);
        }

        public void ReplayAll()
        {
        }

        public void VerifyAll()
        {
        }
        

        public T StrictMock<T>() => default(T);

        public IMessageSource DynamicMock(Type type) => null;

        public void BackToRecordAll() { }

        public IDisposable Record() => null;

        public IDisposable Playback() => null;


        public IDisposable Ordered() => null;
    }

    public static class Expect
    {
        public static CallReturn<T> Call<T>(T data) => new CallReturn<T>();
        public static CallReturn<T> Call<T>(Expression<Func<T>> data) => new CallReturn<T>();
        public static CallReturn<object> Call(Action data) => new CallReturn<object>();
    }

    public class LastCall
    {
        public static CallReturn<object> IgnoreArguments() => new CallReturn<object>();
        public static CallReturn<object> On(object data) => new CallReturn<object>();
    }


    public class CallReturn<T>
    {
        public CallReturn<T> Return(T data) => this;
        public CallReturn<T> IgnoreArguments() => this;
        public CallReturn<T> Any() => this;
        public CallReturn<T> Once() => this;
        public CallReturn<T> Repeat { get => this; }
        public CallReturn<T> AtLeastOnce() => this;
        public CallReturn<T> Throw(Exception ex) => this;
        public CallReturn<T> Twice() => this;
    }
}