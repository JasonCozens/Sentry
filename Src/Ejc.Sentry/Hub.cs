namespace Ejc.Sentry
{
    public class Hub
    {
        private object _listener;

        public void Register(object listener)
        {
            _listener = listener;
        }

        public bool IsRegistered(object listener)
        {
            return _listener != null;
        }

        public void Unregister(object listener)
        {
            _listener = null;
        }
    }
}
