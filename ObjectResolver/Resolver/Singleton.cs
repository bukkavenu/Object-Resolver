using LM = ObjectResolver.LifeTimeManager;

namespace ObjectResolver.Resolver
{
    public class Singleton : ILifeManager
    {        
        public object Create()
        {
            return new LM.SingletonFactory();
        }
    }
}
