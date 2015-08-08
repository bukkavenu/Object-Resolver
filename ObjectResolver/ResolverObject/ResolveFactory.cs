using System;
using System.Collections.Generic;


namespace ObjectResolver.ResolverObject
{
    class ResolveFactory
    {
        private ResolveFactory() { }

        private static ResolveFactory _rd;
        internal static ResolveFactory ResData = ResolveFactory.Instance;
        IDictionary<Type, ResolveObject> dicContainer = new Dictionary<Type, ResolveObject>();

        public ResolveObject this[Type t]
        {
            get
            {
                return dicContainer.ContainsKey(t) ? dicContainer[t] : default(ResolveObject);

            }
            set
            {
                if (dicContainer.ContainsKey(t))
                {
                    dicContainer[t] = value;
                }
                else
                {
                    dicContainer.Add(t, value);
                }

            }
        }

        public static ResolveFactory Instance
        {
            get { return _rd ?? (_rd = new ResolveFactory()); }
        }

    }
}
