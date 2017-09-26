using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace System.Runtime.Remoting
{
    public class RemotingServices
    {
        public static bool IsTransparentProxy(object newValue) => false;

        public static RealProxy GetRealProxy(object target) => new RealProxy(target);
    }

    public class RealProxy
    {
        private object target;

        public RealProxy(object target)
        {
            this.target = target;
        }

        public Type GetProxiedType()
        {
            return target.GetType();
        }
    }

    public interface IRemotingTypeInfo
    {
        bool CanCastTo(Type requiredType, object target);
    }
}

namespace System.Runtime.Remoting.Messaging
{
    public class CallContext
    {
        static ConcurrentDictionary<string, AsyncLocal<object>> state = new ConcurrentDictionary<string, AsyncLocal<object>>();


        public static object GetData(string name) =>
             state.TryGetValue(name, out AsyncLocal<object> data) ? data.Value : null;

        public static void SetData(string name, object data) =>
           state.GetOrAdd(name, _ => new AsyncLocal<object>()).Value = data;

        public static void FreeNamedDataSlot(string name)
        {
            throw new NotImplementedException("CallContext.FreeNamedDataSlot");
        }
    }
}

namespace System.Runtime.Remoting.Proxies
{
    class b
    {
    }
}