using System;

namespace Utilities
{
    public abstract class Singleton<T> where T : new()
    {
        static Singleton() { }
        private static T _instance;

        public static readonly T Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new T();
                return _instance;
            }
        }
    }
}
