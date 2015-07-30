using System;
using RO = ObjectResolver.ResolverObject;

namespace ObjectResolver.Resolver
{
    public class ResolverContainer : IResolver
    {
        public void Register<TInterface, TImplementor>()
        {

            Register(typeof(TInterface), typeof(TImplementor));
        }

        public void Register(Type tInterface, Type tImplementor)
        {
            RO.ResolverFactory.Add(tInterface, tImplementor);
        }

        public void RegisterInstance<TInterface>(object instance)
        {

            RO.ResolverFactory.Add(typeof(TInterface), instance);
        }


        public TInterface Resolve<TInterface>()
        {
            return RO.ResolverFactory.Retrieve<TInterface>();
        }


        public TInterface Resolve<TInterface>(Action<TInterface> act)
        {
            TInterface t = Resolve<TInterface>();
            act(t);
            return t;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ResolverContainer() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
