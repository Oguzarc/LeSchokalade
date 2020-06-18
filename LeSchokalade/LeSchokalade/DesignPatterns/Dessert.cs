using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeSchokalade.DesignPatterns
{
    public abstract class Dessert:Baverages
    {
        public virtual string Prepare()
        {
            string x = "Your dessert will be prepared as soon as possible";
            return x;
        }

        public virtual string Box()
        {
            string x = "Packaging will be done as soon as possible";
            return x;
        }
        public virtual string Ingredients()
        {
            string x = "Ingredients";
            return x;
        }
        
    }
}
