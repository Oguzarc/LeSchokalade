using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeSchokalade.DesignPatterns
{
    class Singleton
    {
        private  Singleton()
        {
            
        }

        private static Singleton obj=null;
        private int pass;
        public static Singleton GiveObj()
        {
            if (obj == null)
            {
                obj = new Singleton();
            }
            return obj;
        }

        public int Compare()
        {
            return pass;
        }

        public void ConfigPass(int value)
        { pass = value; }
    }
}
