using System;
using LM = ObjectResolver.LifeTimeManager;

namespace ObjectResolver.Resolver
{
    public class ResolverContainer : IResolver
    {
        private LM.ILifeTimeManager lifeManager = null;        

        public ResolverContainer()
        {
            lifeManager = new LM.TransientFactory();
        }

        public void Register<TInterface, TImplementor>()
        {

            Register(typeof(TInterface), typeof(TImplementor));
        }

        public void Register(Type tInterface, Type tImplementor)
        {
            lifeManager.Add(tInterface, tImplementor);
        }

        public void RegisterInstance<TInterface>(object instance)
        {
            lifeManager.Add(typeof(TInterface), instance);
        }


        public TInterface Resolve<TInterface>()
        {
            return lifeManager.Retrieve<TInterface>();
        }


        public TInterface Resolve<TInterface>(Action<TInterface> act)
        {
            TInterface t = Resolve<TInterface>();
            act(t);
            return t;
        }

        public IWithLifeTimeResolver With<TILifeManager>()
            where TILifeManager : ILifeManager
        {
            return new WithLifeTimeResolverContainer(Activator.CreateInstance<TILifeManager>().Create());
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    lifeManager.Dispose();
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
