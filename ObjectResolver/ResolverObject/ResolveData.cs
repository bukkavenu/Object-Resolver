using System;
using System.Collections.Generic;


namespace ObjectResolver.ResolverObject
{
    internal class ResolveData
    {
        private ResolveData() { }

        private static ResolveData _rd;
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

        public static ResolveData Instance
        {
            get { return _rd ?? (_rd = new ResolveData()); }
        }

    }
}
