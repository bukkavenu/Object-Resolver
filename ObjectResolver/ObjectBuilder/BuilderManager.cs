using System;
using RO = ObjectResolver.ResolverObject;

namespace ObjectResolver.ObjectBuilder
{
    class BuilderManager : IBuilderManager
    {
        internal BuilderManager() { }

        public IBuilder ObjectBuilder<TInterface>()
        {
            return (IBuilder)Activator.CreateInstance(RO.ResolveFactory.ResData[typeof(TInterface)].BuilderType);
        }

        public TInterface Retrieve<TInterface>()
        {
            return ObjectBuilder<TInterface>().Retrieve<TInterface>();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                }

                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}