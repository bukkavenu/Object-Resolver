using LM = ObjectResolver.LifeTimeManager;

namespace ObjectResolver.Resolver
{
    public class Transient : ILifeManager
    {
        public object Create()
        {
            return new LM.TransientFactory();
        }
    }
}