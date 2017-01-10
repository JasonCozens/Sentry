using System;
using System.Collections.Generic;

namespace Ejc.Sentry
{
    public class Hub
    {
        private readonly List<object> _listeners;

        public Hub()
        {
            _listeners = new List<object>();
        }

        public void Register(object listener)
        {
            if (_listeners.Contains(listener)) throw new InvalidOperationException();
            _listeners.Add(listener);
        }

        public bool IsRegistered(object listener)
        {
            return _listeners.Contains(listener);
        }

        public void Unregister(object listener)
        {
            _listeners.Remove(listener);
        }
    }
}
