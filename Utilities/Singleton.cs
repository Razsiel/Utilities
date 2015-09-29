using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Singleton
    {
        private static Singleton _instance;

        public static Singleton Instance
        {
            get
            {
                if( _instance == null)
                    _instance = new Singleton();
                return _instance;
            }
        }
    }
}
