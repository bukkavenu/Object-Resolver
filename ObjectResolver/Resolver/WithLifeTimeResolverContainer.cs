using System;
using LM = ObjectResolver.LifeTimeManager;

namespace ObjectResolver.Resolver
{
    class WithLifeTimeResolverContainer : IWithLifeTimeResolver
    {
        private LM.ILifeTimeManager lifeManager = new LM.TransientFactory();

        internal WithLifeTimeResolverContainer(LM.ILifeTimeManager manager)
        {
            lifeManager = manager;
        }

        public WithLifeTimeResolverContainer(object manager)
        {
            this.lifeManager = (LM.ILifeTimeManager)manager;
        }

        public void Register<TInterface, TImplementor>()
        {
            Register(typeof(TInterface), typeof(TImplementor));
        }

        public void Register(Type tInterface, Type tImplementor)
        {
            lifeManager.Add(tInterface, tImplementor);
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
                    lifeManager.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~WithLifeTimeResolverContainer() {
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
