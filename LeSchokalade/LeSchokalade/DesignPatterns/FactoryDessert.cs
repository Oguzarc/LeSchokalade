using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeSchokalade.DesignPatterns
{
    public abstract class AbstractStore
    {
        public Dessert OrderDessert(string dessertType)
        {
            Dessert dessert = CreateDessert(dessertType);

            dessert.Prepare();
            dessert.Box();
            dessert.Ingredients();         
            return dessert;
        }

        protected abstract Dessert CreateDessert(string type);
    }

    public class LeShokaladeDukkan : AbstractStore
    {
       
        protected override Dessert CreateDessert(string type)
        {
            Dessert dessert = null;

            if (type == "sude")
            {
                dessert = new LeShokaladeSude();

            }
            else if(type == "neriman")
            {
                dessert = new LeShokaladeNeriman();
            }
                return dessert;
        }
    }
}
